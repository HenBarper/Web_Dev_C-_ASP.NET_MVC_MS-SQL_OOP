using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Partial_Class_Udemy_Web_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public partial class Employee
        {
            public int employeeID { get; set; }
            public string employeeName { get; set; }
        
            public double employeeSalary { get; set; }
        }

        public partial class Employee
        {
            public void SetValues()
            {
                employeeID = 1;
                employeeName = "Ben";
                employeeSalary = 50000;
            }
        }

        public sealed class SealedClass
        { }

        //public class newClass : SealedClass { }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.SetValues();
            textBox1.Text += $"ID: {employee.employeeID}" + Environment.NewLine;
            textBox1.Text += $"Name: {employee.employeeName}" + Environment.NewLine;
            textBox1.Text += $"Salary: {employee.employeeSalary}" + Environment.NewLine;
        }
    }
}
