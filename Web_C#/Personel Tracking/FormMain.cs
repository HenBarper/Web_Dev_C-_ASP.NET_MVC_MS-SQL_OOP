using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Tracking {
    public partial class FormMain : Form {
        public FormMain() {
            InitializeComponent();
        }        

        // BUTTON 1 - EMPLOYEE
        private void buttonEmployee_Click(object sender, EventArgs e) {
            FormEmployeeList formEmployeeList = new FormEmployeeList();
            this.Hide();
            formEmployeeList.ShowDialog();
            this.Visible = true; // Shows FormMain when FormEmployeeList closed
        }

        // BUTTON 2 - TASK
        private void buttonTask_Click(object sender, EventArgs e) {
            FormTaskList formTaskList = new FormTaskList();
            this.Hide();
            formTaskList.ShowDialog();
            this.Visible = true; // Shows FormMain when FormTaskList closed
        }

        // BUTTON 3 - SALARY
        private void buttonSalary_Click(object sender, EventArgs e) {
            FormSalaryList formSalaryList = new FormSalaryList();
            this.Hide();
            formSalaryList.ShowDialog();
            this.Visible = true; // Shows FormMain when FormSalaryList closed
        }

        // BUTTON 4 - PERMISSION
        private void buttonPermission_Click(object sender, EventArgs e) {
            FormPermissionList formPermissionList = new FormPermissionList();
            this.Hide();
            formPermissionList.ShowDialog();
            this.Visible = true; // Shows FormMain when FormPermissionList closed
        }

        // BUTTON 5 - DEPARTMENT
        private void buttonDepartment_Click(object sender, EventArgs e) {
            FormDepartmentList formDepartmentList = new FormDepartmentList();
            this.Hide();
            formDepartmentList.ShowDialog();
            this.Visible = true; // Shows FormMain when FormDepartmentList closed
        }

        // BUTTON 6 - POSITION
        private void buttonPosition_Click(object sender, EventArgs e) {
            FormPositionList formPositionList = new FormPositionList();
            this.Hide();
            formPositionList.ShowDialog();
            this.Visible = true; // Shows FormMain when FormPositionList closed
        }

        // BUTTON 7 - LOG OUT
        private void buttonLogOut_Click(object sender, EventArgs e) {
            FormLogin formLogin = new FormLogin();
            this.Hide();
            formLogin.ShowDialog();
        }

        // BUTTON 8 - EXIT APPLICATION
        private void buttonExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        // EXIT APPLICATION ON FORM CLOSE
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
    }
}
