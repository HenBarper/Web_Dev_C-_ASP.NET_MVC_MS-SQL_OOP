using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using DAL.DTO;
using System.IO;

namespace Personel_Tracking {
    public partial class FormEmployee : Form {

        EmployeeDTO dto = new EmployeeDTO();
        bool comboFull = false;
        string employeePhotoFilename = "";
        bool employeeNoIsUnique = false;

        public FormEmployee() {
            InitializeComponent();
        }

        // HANDLE USER NUMBER, NUMBERS ONLY
        private void textBoxUserNumber_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = General.isNumber(e);
        }

        // HANDLE SALARY, NUMBERS ONLY
        private void textBoxSalary_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = General.isNumber(e);
        }

        // ON EMPLOYEE FORM LOAD
        private void FormEmployee_Load(object sender, EventArgs e) {
            dto = EmployeeBLL.GetAll();
            comboBoxDepartment.DataSource = dto.Departments;
            comboBoxDepartment.DisplayMember = "DepartmentName";
            comboBoxDepartment.ValueMember = "DepartmentID";
            comboBoxDepartment.SelectedIndex = -1;

            comboBoxPosition.DataSource = dto.Positions;
            comboBoxPosition.DisplayMember = "PositionName";
            comboBoxPosition.ValueMember = "PositionID";
            comboBoxPosition.SelectedIndex = -1;

            comboFull = true;
        }

        // CHECK USER NUMER IS UNIQUE
        private void buttonCheck_Click(object sender, EventArgs e) {
            if (textBoxUserNumber.Text.Trim() == "") {
                MessageBox.Show("User number is empty. Please enter a user number");
            }
            else {
                employeeNoIsUnique = EmployeeBLL.isUnique(Convert.ToInt32(textBoxUserNumber.Text));
                if (!employeeNoIsUnique) {
                    MessageBox.Show("This user number is already used by another employee. Please change the user number");
                }
                else {
                    MessageBox.Show("This user number is available");
                }
            }
        }

        // CHANGED DEPARTMENT COMBO BOX
        private void comboBoxDepartment_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboFull) {
                int departmentID = Convert.ToInt32(comboBoxDepartment.SelectedValue);
                comboBoxPosition.DataSource = dto.Positions.Where(x => x.DepartmentID == departmentID).ToList();
            }
        }

        // BROWSE PHOTOS BUTTON TO ADD PICTURE
        private void buttonBrowse_Click(object sender, EventArgs e) {
            if(openFileDialog1.ShowDialog() == DialogResult.OK) {
                pictureBox1.Load(openFileDialog1.FileName);
                textBoxImagePath.Text = openFileDialog1.FileName;
                string uniqueGUID = Guid.NewGuid().ToString();
                employeePhotoFilename += uniqueGUID + openFileDialog1.SafeFileName;
            }
        }

        // SAVE NEW EMPLOYEE TO DATABASE
        private void buttonSave_Click(object sender, EventArgs e) {
            if(textBoxUserNumber.Text.Trim() == "") {
                MessageBox.Show("User number is empty. Please enter a user number");
            }
            else if (!EmployeeBLL.isUnique(Convert.ToInt32(textBoxUserNumber.Text))) {
                MessageBox.Show("This user number is already used by another employee. Please change the user number");
            } else if (textBoxPassword.Text.Trim() == "") {
                MessageBox.Show("Password is empty. Please enter a password");
            }
            else if (textBoxSurname.Text.Trim() == "") {
                MessageBox.Show("Surname is empty. Please enter a surname");
            } 
            else if (textBoxSalary.Text.Trim() == "") {
                MessageBox.Show("Salary is empty. Please enter a salary");
            } 
            else if (comboBoxDepartment.SelectedIndex == -1) {
                MessageBox.Show("Department not selected. Please select a department");
            }
            else if (comboBoxPosition.SelectedIndex == -1) {
                MessageBox.Show("Position not selected. Please select a Position");
            }
            else {
                EMPLOYEE employee = new EMPLOYEE();
                employee.UserNumber = Convert.ToInt32(textBoxUserNumber.Text);
                employee.Password = textBoxPassword.Text;
                employee.isAdmin = checkBoxAdmin.Checked;
                employee.Name = textBoxName.Text;
                employee.Surname = textBoxSurname.Text;
                employee.Salaray = Convert.ToInt32(textBoxSalary.Text);
                employee.DepartmentID = Convert.ToInt32(comboBoxDepartment.SelectedValue);
                employee.PositionID = Convert.ToInt32(comboBoxPosition.SelectedValue);
                employee.Address = textBoxAddress.Text;
                employee.Birthday = dateTimeBirthday.Value;
                employee.ImagePath = employeePhotoFilename;
                EmployeeBLL.AddEmployee(employee);
                File.Copy(textBoxImagePath.Text, @"images\\" + employeePhotoFilename);
                MessageBox.Show("Employee was added");
                textBoxUserNumber.Clear();
                textBoxPassword.Clear();
                checkBoxAdmin.Checked = false;
                textBoxName.Clear();
                textBoxSurname.Clear();
                textBoxSalary.Clear();
                textBoxAddress.Clear();
                textBoxImagePath.Clear();
                pictureBox1.Image = null;
                comboFull = false;
                comboBoxDepartment.SelectedIndex = -1;
                comboBoxPosition.DataSource = dto.Positions;
                comboBoxPosition.SelectedIndex = -1;
                comboFull = true;
                dateTimeBirthday.Value = DateTime.Today;
            }
        }

        // CLOSE EMPLOYEE FORM
        private void buttonClose_Click(object sender, EventArgs e) {
            this.Close();
        }        
    }
}
