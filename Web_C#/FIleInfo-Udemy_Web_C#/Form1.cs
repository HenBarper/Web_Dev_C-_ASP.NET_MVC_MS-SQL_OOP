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

namespace FIleInfo_Udemy_Web_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Using FIle
            //File.Create("firstfile.txt");

            // Using FileInfo
            FileInfo ourfile = new FileInfo("secondfile.txt");
            ourfile.Create();
        }

        private void buttonWrite_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("thirdfile.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("This is the first line.");
            sw.WriteLine("This is the second line.");
            sw.Flush();

            // Both streams must be closed
            sw.Close();
            fs.Close();
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("thirdfile.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string text = "";
            while (!sr.EndOfStream) 
            {
                text += sr.ReadLine() + Environment.NewLine;
            }
            sr.Close();
            fs.Close();
            textBox1.Text = text;
        }
    }
}
