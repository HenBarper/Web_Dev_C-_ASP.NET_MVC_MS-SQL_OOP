using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enum_Udemy_Web_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum colors { red = 5, blue, green, yellow, orange = 25, purple, black, white, gray };

        private void button1_Click(object sender, EventArgs e)
        {
            string text = $"Red: {(int)colors.red}" + Environment.NewLine;
            text += $"Blue: {(int)colors.blue}" + Environment.NewLine;
            text += $"Green: {(int)colors.green}" + Environment.NewLine;
            text += $"Yellow: {(int)colors.yellow}" + Environment.NewLine;
            text += $"Orange: {(int)colors.orange}" + Environment.NewLine;
            text += $"Purple: {(int)colors.purple}" + Environment.NewLine;
            text += $"Black: {(int)colors.black}" + Environment.NewLine;
            text += $"White: {(int)colors.white}" + Environment.NewLine;
            text += $"Gray: {(int)colors.gray}" + Environment.NewLine;
            textBox1.Text = text;
        }
    }
}
