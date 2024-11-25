using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DAL.DTO;
using BLL;

namespace Personel_Tracking {
    public partial class FormTask : Form {

        TaskDTO dto = new TaskDTO();
        private bool comboFull = false;
        TASK task = new TASK();

        public FormTask() {
            InitializeComponent();
        }

        // ON LOAD
        private void FormTask_Load(object sender, EventArgs e) {
            // Hide task state label & combo box
            labelTaskState.Visible = false;
            comboBoxTaskState.Visible = false;

            // Fill datagrid view
            dto = TaskBLL.GetAll();
            dataGridView1.DataSource = dto.Employees;
            dataGridView1.Columns[0].Visible = false; // Hide EmployeeID
            dataGridView1.Columns[1].HeaderText = "User Number";
            dataGridView1.Columns[2].HeaderText = "Name";
            dataGridView1.Columns[3].HeaderText = "Surname";
            dataGridView1.Columns[4].Visible = false; // Hide Department Name
            dataGridView1.Columns[5].Visible = false; // Hide Position Name
            dataGridView1.Columns[6].Visible = false; // Hide DeptartmentID
            dataGridView1.Columns[7].Visible = false; // Hide PositionID
            dataGridView1.Columns[8].Visible = false; // Hide Salary
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

            comboBoxTaskState.DataSource = dto.TaskStates;
            comboBoxTaskState.DisplayMember = "TaskName";
            comboBoxTaskState.ValueMember = "TaskStateID";
            comboBoxTaskState.SelectedIndex = -1;
        }

        // DEPARTMENT COMBO BOX SELECT CHANGE
        private void comboBoxDepartment_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboFull) {
                comboBoxPosition.DataSource = dto.Positions.Where(x => x.DepartmentID ==
                Convert.ToInt32(comboBoxDepartment.SelectedValue)).ToList();

                List<EmployeeDetailDTO> list = dto.Employees;
                dataGridView1.DataSource = list.Where(x => x.DepartmentID ==
                Convert.ToInt32(comboBoxDepartment.SelectedValue)).ToList();
            }
        }

        // POSITION COMBO BOX SELECT CHANGE
        private void comboBoxPosition_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboFull) {
                List<EmployeeDetailDTO> list = dto.Employees;
                dataGridView1.DataSource = list.Where(x => x.PositionID ==
                Convert.ToInt32(comboBoxPosition.SelectedValue)).ToList();
            }
        }

        // DATAGRID ROW ENTER
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e) {
            textBoxUserNumber.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxSurname.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            task.EmployeeID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
        }

        // SAVE NEW TASK
        private void buttonSave_Click(object sender, EventArgs e) {
            if (task.EmployeeID == 0) {
                MessageBox.Show("Please select an employee an table");
            }
            else if (textBoxTaskTitle.Text.Trim() == "") {
                MessageBox.Show("Task title is empty");
            }
            else if (textBoxTaskContent.Text.Trim() == "") {
                MessageBox.Show("Task content is empty");
            }
            else {
                // Add task
                task.TaskTitle = textBoxTaskTitle.Text;
                task.TaskContent = textBoxTaskContent.Text;
                task.TaskStartDate = DateTime.Now;
                task.TaskState = 1;
                TaskBLL.AddTask(task);
                MessageBox.Show("Task was added");

                // Clear all data after save
                textBoxTaskTitle.Clear();
                textBoxTaskContent.Clear();
                task = new TASK();
            }
        }

        // CLOSE TASK FORM
        private void buttonClose_Click(object sender, EventArgs e) {
            this.Close();
        }        
    }
}
