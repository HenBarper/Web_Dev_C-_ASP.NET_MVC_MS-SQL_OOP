using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegates_Udemy_Web_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public delegate void FillTextBox(int x);

        string textValue = "";

        public void FillMathNote(int examNote)
        {
            textValue += $"Your math note is {examNote}" + Environment.NewLine;
        }

        public void FillChemistryNote(int examNote) 
        {
            textValue += $"Your chemistry note is {examNote}" + Environment.NewLine;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void ShowInTextBox()
        {
            textBox1.Text = textValue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Version 1 - Standard
            //FillTextBox fillText = FillMathNote;
            //fillText(80);
            //ShowInTextBox();

            // Version 2 - new keyword
            //filltextbox filltext = new filltextbox(fillmathnote);
            //filltext(80);
            //showintextbox();

            // Version 3 - Invoke
            //FillTextBox fillText = new FillTextBox(FillMathNote);
            //fillText.Invoke(80);
            //ShowInTextBox();

            // Version 4 - Multicast Delegate(Add)
            //FillTextBox fillText = new FillTextBox(FillMathNote);
            //fillText += FillChemistryNote;
            //fillText(80);
            //ShowInTextBox();

            // Version 5 - Multicast Delegate(Add & Remove)
            FillTextBox fillText = new FillTextBox(FillMathNote);
            fillText += FillChemistryNote;
            fillText(80);
            ShowInTextBox();
            fillText -= FillMathNote;
            fillText(60);
            ShowInTextBox();
        }
    }
}
