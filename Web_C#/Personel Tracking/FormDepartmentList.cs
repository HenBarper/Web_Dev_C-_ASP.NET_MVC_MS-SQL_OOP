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

namespace Personel_Tracking {
    public partial class FormDepartmentList : Form {

        List<DEPARTMENT> departmentList = new List<DEPARTMENT>();

        public FormDepartmentList() {
            InitializeComponent();
        }        

        // FORM LOAD
        private void FormDepartmentList_Load(object sender, EventArgs e) {            
            departmentList = BLL.DepartmentBLL.GetDepartments();
            dataGridView1.DataSource = departmentList;
            dataGridView1.Columns[0].Visible = false; // Hide departmentID
            //dataGridView1.Columns[0].HeaderText = "Department ID";
            dataGridView1.Columns[1].HeaderText = "Department Name";
        }

        // ADD NEW DEPARTMENT
        private void buttonNew_Click(object sender, EventArgs e) {
            FormDepartment formDepartment = new FormDepartment();
            this.Hide();
            formDepartment.ShowDialog();
            this.Visible = true; // Shows FormDepartmentList when FormDepartment closed
            departmentList = DepartmentBLL.GetDepartments();
            dataGridView1.DataSource = departmentList;
        }

        // UPDATE DEPARTMENT
        private void buttonUpdate_Click(object sender, EventArgs e) {
            FormDepartment formDepartment = new FormDepartment();
            this.Hide();
            formDepartment.ShowDialog();
            this.Visible = true; // Shows FormDepartmentList when FormDepartment closed
        }

        // CLOSE DEPARTMENT LIST FORM
        private void buttonClose_Click(object sender, EventArgs e) {
            this.Close();
        }        
    }
}
