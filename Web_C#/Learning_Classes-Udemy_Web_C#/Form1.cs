using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learning_Classes_Udemy_Web_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Employee personalDetail = new Employee();

        private void btnSetVals_Click(object sender, EventArgs e)
        {
            
            personalDetail.employeeID = Convert.ToInt32(textEmployeeID.Text);
            personalDetail.name = textName.Text;
            personalDetail.age = Convert.ToInt32(textAge.Text);
            MessageBox.Show("All data received!");
        }

        private void btnSendVals_Click(object sender, EventArgs e)
        {
            personalDetail.employeeID = Convert.ToInt32(textEmployeeID.Text);
            personalDetail.name = textName.Text;
            personalDetail.age = Convert.ToInt32(textAge.Text);
            Form2 theForm = new Form2();
            theForm.personelDetail = personalDetail;
            theForm.ShowDialog();
        }
    }
}
