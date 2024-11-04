using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_Udemy_Web_C_
{
    public partial class Form1 : Form
    {
        int counter = 100;
        public Form1()
        {
            InitializeComponent();
            progressBar1.ForeColor = Color.Red;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counter > 0)
            {
                counter -= 5;
            }
            progressBar1.Value = counter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
