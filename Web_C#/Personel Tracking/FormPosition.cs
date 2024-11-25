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

    public partial class FormPosition : Form {

        List<DEPARTMENT> departmentList = new List<DEPARTMENT>();

        public FormPosition() {
            InitializeComponent();
        }

        // ON POSITION FORM LOAD
        private void FormPosition_Load(object sender, EventArgs e) {
            departmentList = DepartmentBLL.GetDepartments();
            comboBoxDepartment.DataSource = departmentList;
            comboBoxDepartment.DisplayMember = "DepartmentName";
            comboBoxDepartment.ValueMember = "DepartmentID";
            comboBoxDepartment.SelectedIndex = -1;
        }

        // SAVE NEW POSITION
        private void buttonSave_Click(object sender, EventArgs e) {
            if(textBoxPosition.Text.Trim() == "") {
                MessageBox.Show("Please fill in position name");
            }
            else if(comboBoxDepartment.SelectedIndex == -1) {
                MessageBox.Show("Please select a department");
            }
            else {
                POSITION position = new POSITION();
                position.PositionName = textBoxPosition.Text;
                position.DepartmentID = Convert.ToInt32(comboBoxDepartment.SelectedValue);
                BLL.PositionBLL.AddPosition(position);
                MessageBox.Show("Position was added");
                textBoxPosition.Clear();
                comboBoxDepartment.SelectedIndex = -1;
            }
        }

        // CLOSE POSITION FORM
        private void buttonClose_Click(object sender, EventArgs e) {
            this.Close();
        }        
    }
}
