using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Get__and_Set_Udemy_Web_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee employeeDetails = new Employee();
            employeeDetails.employeeID = Convert.ToInt32(textID.Text);
            employeeDetails.employeeName = textName.Text;
            employeeDetails.employeeAge = Convert.ToInt32(textAge.Text);
            employeeDetails.employeePosition = textPosition.Text;
            EmployeeDetails deetsForm = new EmployeeDetails();
            deetsForm.labelName.Text = employeeDetails.employeeName;
            deetsForm.labelAge.Text = employeeDetails.employeeAge.ToString();
            deetsForm.labelPosition.Text = employeeDetails.employeePosition;
            deetsForm.ShowDialog();
        }
    }
}
