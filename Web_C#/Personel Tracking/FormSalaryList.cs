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
    public partial class FormSalaryList : Form {
        public FormSalaryList() {
            InitializeComponent();
        }        


        // ADD NEW SALARY
        private void buttonNew_Click(object sender, EventArgs e) {
            FormSalary formSalary = new FormSalary();
            this.Hide();
            formSalary.ShowDialog();
            this.Visible = true; // Shows FormSalaryList when FormSalary closed
        }

        // UPDATE SALARY
        private void buttonUpdate_Click(object sender, EventArgs e) {
            FormSalary formSalary = new FormSalary();
            this.Hide();
            formSalary.ShowDialog();
            this.Visible = true; // Shows FormSalaryList when FormSalary closed
        }

        // CLOSE SALARY LIST FORM
        private void buttonClose_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
