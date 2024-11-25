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
    public partial class FormDepartment : Form {
        public FormDepartment() {
            InitializeComponent();
        }
                
        // SAVE NEW DEPARTMENTS
        private void buttonSave_Click(object sender, EventArgs e) {
            if (textBoxDepartment.Text.Trim() == "") {
                MessageBox.Show("Please fill the name field");
            } else {
                DEPARTMENT department = new DEPARTMENT();
                department.DepartmentName = textBoxDepartment.Text;
                BLL.DepartmentBLL.AddDepartment(department);
                MessageBox.Show("Department added successfully.");
                textBoxDepartment.Clear();
            }
        }

        // CLOSE DEPARMENT FORM
        private void buttonClose_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
