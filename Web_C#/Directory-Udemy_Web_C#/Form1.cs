using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Directory_Udemy_Web_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            // Use Exists for control purposes

            if (!Directory.Exists("folder2"))
            {
                Directory.CreateDirectory("folder2");
            }
            else
            {
                MessageBox.Show("That folder already exists!");
            }

            // Using Directory
            //Directory.CreateDirectory("temp");
            //Directory.CreateDirectory("gurbles");

            // Using DirectoryInfo
            //DirectoryInfo dr = new DirectoryInfo("DI WHYYY");
            //dr.Create();
            //MessageBox.Show("Folder created");
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            Directory.Move("temp", @"C:\\Users\\benja\\source\\repos\\Directory-Udemy_Web_C#\\bin\\temp");
            MessageBox.Show("Folder moved");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Directory.Delete("gurbles");
            MessageBox.Show("Folder deleted");
        }
    }
}
