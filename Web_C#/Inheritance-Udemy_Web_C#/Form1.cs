using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance_Udemy_Web_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Teacher newTeacher = new Teacher();
            newTeacher.SetValues();
            newTeacher.SetValues2();
            string allValues = "";
            allValues += "ID: " + newTeacher.ID + Environment.NewLine;
            allValues += "Name: " + newTeacher.name + Environment.NewLine;
            allValues += "Surname: " + newTeacher.surName + Environment.NewLine;
            allValues += "Age: " + newTeacher.age + Environment.NewLine;
            allValues += "Gender: " + newTeacher.gender + Environment.NewLine;
            allValues += "Subject: " + newTeacher.branch + Environment.NewLine;
            allValues += "Salary: " + (newTeacher.FindSalary()).ToString() + Environment.NewLine;
            textBox1.Text = allValues;
        }
    }
}
