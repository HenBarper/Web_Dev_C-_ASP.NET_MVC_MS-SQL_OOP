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
using DAL.DAO;
using BLL;
using DAL.DTO;

namespace Personel_Tracking {
    public partial class FormTaskList : Form {

        TaskDTO dto = new TaskDTO();
        private bool comboFull = false;

        public FormTaskList() {
            InitializeComponent();
        }

        // HANDLE USER NUMBER, NUMBERS ONLY
        private void textBoxUserNumber_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = General.isNumber(e);
        }
        
        // FILL ALL DATA
        void FillAllData() {
            dto = TaskBLL.GetAll();
            dataGridView1.DataSource = dto.Tasks;

            // Fill combo boxes
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

        // HIDE ADMIN PANEL ON LOAD
        private void FormTaskList_Load(object sender, EventArgs e) {
            //panelForAdmin.Visible = false;

            // Fill task data
            FillAllData();
            dataGridView1.Columns[0].HeaderText = "Task Title";
            dataGridView1.Columns[1].HeaderText = "User Number";
            dataGridView1.Columns[2].HeaderText = "Name";
            dataGridView1.Columns[3].HeaderText = "Surname";
            dataGridView1.Columns[4].HeaderText = "Start Date";
            dataGridView1.Columns[5].HeaderText = "Delivery Date";
            dataGridView1.Columns[6].HeaderText = "Task State";
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;            
        }

        // DEPARTMENT COMBO BOX SELECT CHANGE
        private void comboBoxDepartment_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboFull) {
                comboBoxPosition.DataSource = dto.Positions.Where(x => x.DepartmentID ==
                Convert.ToInt32(comboBoxDepartment.SelectedValue)).ToList();
            }
        }

        // SEARCH BUTTON 
        private void buttonSearch_Click(object sender, EventArgs e) {
            List<TaskDetailDTO> list = new List<TaskDetailDTO>();
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
            if(radioButtonStartDate.Checked) {
                list = list.Where(x => x.TaskStartDate > Convert.ToDateTime(dateTimePickerStart.Value) &&
                x.TaskStartDate < Convert.ToDateTime(dateTimePickerEnd.Value)).ToList();
            }
            if (radioButtonDeliveryDate.Checked) {
                list = list.Where(x => x.TaskDeliveryDate > Convert.ToDateTime(dateTimePickerStart.Value) &&
                x.TaskDeliveryDate < Convert.ToDateTime(dateTimePickerEnd.Value)).ToList();
            }
            if (comboBoxTaskState.SelectedIndex == -1) {
                list = list.Where(x => x.taskStateID == Convert.ToInt32(comboBoxTaskState.SelectedValue)).ToList();
            }
            dataGridView1.DataSource = list;
        }

        // CLEAR FILTERS
        private void buttonClear_Click(object sender, EventArgs e) {
            CleanFilters();
        }

        private void CleanFilters() {
            textBoxUserNumber.Clear();
            textBoxName.Clear();
            textBoxSurname.Clear();
            comboFull = false;
            comboBoxDepartment.SelectedIndex = -1;
            comboBoxPosition.DataSource = dto.Positions;
            comboBoxPosition.SelectedIndex = -1;
            comboFull = true;
            radioButtonDeliveryDate.Checked = false;
            radioButtonStartDate.Checked = false;
            comboBoxTaskState.SelectedIndex = -1;
            dataGridView1.DataSource = dto.Tasks;
        }

        // ADD NEW TASK
        private void buttonNew_Click(object sender, EventArgs e) {
            FormTask formTask = new FormTask();
            this.Hide();
            formTask.ShowDialog();
            this.Visible = true;
            FillAllData();
            CleanFilters();
        }


        // UPDATE TASK
        private void buttonUpdate_Click(object sender, EventArgs e) {
            FormTask formTask = new FormTask();
            this.Hide();
            formTask.ShowDialog();
            this.Visible = true;
        }        

        // CLOSE FORM
        private void buttonClose_Click(object sender, EventArgs e) {
            this.Close();
        }        
    }
}
