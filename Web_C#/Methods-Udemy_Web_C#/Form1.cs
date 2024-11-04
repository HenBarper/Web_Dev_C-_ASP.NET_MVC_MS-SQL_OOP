using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methods_Udemy_Web_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void HideRadioButtons() 
        {
            groupBox1.Visible = false;
        }

        public void ClearAllText() 
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        public void FillTextBox(string text) 
        {
            textBox2.Text = text;
        }

        public void SetNumber(int age) 
        {
            label1.Text = $"You are {age.ToString()} years old";
        }

        string GetName() 
        {
            string name = "Charles";
            return name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //HideRadioButtons();
            //ClearAllText();
            //FillTextBox(textBox1.Text);
            //SetNumber(35);
            string name = GetName();
            MessageBox.Show(name);
        }
    }
}
