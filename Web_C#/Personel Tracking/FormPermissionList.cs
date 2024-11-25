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
    public partial class FormPermissionList : Form {
        public FormPermissionList() {
            InitializeComponent();
        }


        // HANDLE USER NUMBER, NUMBERS ONLY
        private void textBoxUserNumber_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = General.isNumber(e);
        }

        // HANDLE DAY AMOUNT, NUMBERS ONLY
        private void textBoxDayAmount_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = General.isNumber(e);
        }        

        // ADD NEW PERMISSION
        private void buttonNew_Click(object sender, EventArgs e) {
            FormPermission formPermission = new FormPermission();
            this.Hide();
            formPermission.ShowDialog();
            this.Visible = true; // Shows FormPermissionList when FormPermission closed
        }

        // UPDATE PERMISSION
        private void buttonUpdate_Click(object sender, EventArgs e) {
            FormPermission formPermission = new FormPermission();
            this.Hide();
            formPermission.ShowDialog();
            this.Visible = true; // Shows FormPermissionList when FormPermission closed
        }

        // CLOSE PERMISSION LIST FORM
        private void buttonClose_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
