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
    public partial class FormLogin : Form {
        public FormLogin() {
            InitializeComponent();
        }

        // HANDLE EMPLOYEE NUMBER BOX NUMBERS ONLY
        private void textBoxUserNumber_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = General.isNumber(e);
        }

        // LOGIN
        private void buttonLogin_Click(object sender, EventArgs e) {
            FormMain form = new FormMain();
            this.Hide();
            form.ShowDialog();
        }

        // EXIT APPLICATION
        private void buttonExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }        
    }
}
