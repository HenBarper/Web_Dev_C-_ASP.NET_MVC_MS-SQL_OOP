using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorphism_Udemy_Web_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.SetValues(1);
            string messageText = teacher.GetValues().ToString();
            textBox1.Text = messageText;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.SetValues(2, "Mrs. Butt");
            string messageText = teacher.GetValues().ToString();
            textBox1.Text = messageText;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.SetValues(3, "Mr. Nut", 45.50);
            string messageText = teacher.GetValues().ToString();
            textBox1.Text = messageText;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.SetValues(4, "Miss Jutt", 32.69, "Prof of booger");
            string messageText = teacher.GetValues().ToString();
            textBox1.Text = messageText;
        }

        private void buttonVirtual_Click(object sender, EventArgs e)
        {
            Employee2 employee = new Employee2();
            string messageText = employee.SetValues(5, "Mr. Garkle", 2.50);
            textBox1.Text = messageText;
        }

        private void buttonOverride_Click(object sender, EventArgs e)
        {
            Teacher2 teacher = new Teacher2();
            string messageText = teacher.SetValues(6, "Mrs. Dooble", 19.75);
            textBox1 .Text = messageText;
        }
    }
}
