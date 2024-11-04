using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exception_Control_Udemy_Web_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            int result = 0;
            try
            {
                result = Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text);
                labelResult.Text = $"Result: {result.ToString()}";
            }
            catch (DivideByZeroException ex)
            {
                throw new Exception("You cannot divide by 0");
                //labelResult.Text = $"Result: invalid";
            }
            catch (Exception ex)
            {
                throw new Exception("Please use only numbers!");
            }
            finally
            {
                MessageBox.Show("Program Finished");
            }
        }
    }
}
