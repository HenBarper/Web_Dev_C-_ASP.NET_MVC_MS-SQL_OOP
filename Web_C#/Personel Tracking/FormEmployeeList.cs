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

namespace Personel_Tracking {
    public partial class FormEmployeeList : Form {

        EmployeeDTO dto = new EmployeeDTO();
        bool comboFull = false;

        public FormEmployeeList() {
            InitializeComponent();
        }

        // HANDLE USER NUMBER, NUMBERS ONLY
        private void textBoxUserNumber_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = General.isNumber(e);
        }

        // ON EMPLOYEE LIST FORM LOAD
        private void FormEmployeeList_Load(object sender, EventArgs e) {
            dto = EmployeeBLL.GetAll();
            dataGridView1.DataSource = dto.Employees;
            dataGridView1.Columns[0].Visible = false; // Hide EmployeeID
            dataGridView1.Columns[1].HeaderText = "User Number";
            dataGridView1.Columns[2].HeaderText = "Name";
            dataGridView1.Columns[3].HeaderText = "Surname";
            dataGridView1.Columns[4].HeaderText = "Department";
            dataGridView1.Columns[5].HeaderText = "Position";
            dataGridView1.Columns[6].Visible = false; // Hide DeptartmentID
            dataGridView1.Columns[7].Visible = false; // Hide PositionID
            dataGridView1.Columns[8].HeaderText = "Salary";
            dataGridView1.Columns[9].Visible = false; // Hide isAdmin
            dataGridView1.Columns[10].Visible = false; // Hide Password
            dataGridView1.Columns[11].Visible = false; // Hide ImagePath
            dataGridView1.Columns[12].Visible = false; // Hide Address
            dataGridView1.Columns[13].Visible = false; // Hide Birthday

            comboFull = false;

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

        // CHANGE DEPARTMENT COMBO BOX
        private void comboBoxDepartment_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboFull) {
                comboBoxPosition.DataSource = dto.Positions.Where(x => x.DepartmentID == Convert.ToInt32(comboBoxDepartment.SelectedValue)).ToList();
            }
        }

        // SEARCH
        private void buttonSearch_Click(object sender, EventArgs e) {
            List<EmployeeDetailDTO> list = dto.Employees;
            if (textBoxUserNumber.Text.Trim() != "") {
                list = list.Where(x => x.UserNo == Convert.ToInt32(textBoxUserNumber.Text)).ToList();
            }
            if (textBoxName.Text.Trim() != "") {
                list = list.Where(x => x.Name.Contains(textBoxName.Text)).ToList();
            }
            if (textBoxSurname.Text.Trim() != "") {
                list = list.Where(x => x.Surname.Contains(textBoxSurname.Text)).ToList();
            }
            if (comboBoxDepartment.SelectedIndex != -1) {
                list = list.Where(x => x.DepartmentID == Convert.ToInt32(comboBoxDepartment.SelectedValue)).ToList();
            }
            if (comboBoxPosition.SelectedIndex != -1) {
                list = list.Where(x => x.PositionID == Convert.ToInt32(comboBoxPosition.SelectedValue)).ToList();
            }
            dataGridView1.DataSource = list;
        }

        // CLEAR
        private void buttonClear_Click(object sender, EventArgs e) {
            textBoxUserNumber.Clear();
            textBoxName.Clear();
            textBoxSurname.Clear();
            comboFull = false;
            comboBoxDepartment.SelectedIndex = -1;
            comboBoxPosition.DataSource = dto.Positions;
            comboBoxPosition.SelectedIndex = -1;
            comboFull = true;
            dataGridView1.DataSource = dto.Employees;
        }

        // ADD NEW EMPLOYEE
        private void buttonNew_Click(object sender, EventArgs e) {
            FormEmployee formEmployee = new FormEmployee();
            this.Hide();
            formEmployee.ShowDialog();
            this.Visible = true;
        }

        // UPDATE EMPLOYEE
        private void buttonUpdate_Click(object sender, EventArgs e) {
            FormEmployee formEmployee = new FormEmployee();
            this.Hide();
            formEmployee.ShowDialog();
            this.Visible = true;
        }

        // CLOSE FORM
        private void buttonClose_Click(object sender, EventArgs e) {
            this.Close();
        }        
    }
}
