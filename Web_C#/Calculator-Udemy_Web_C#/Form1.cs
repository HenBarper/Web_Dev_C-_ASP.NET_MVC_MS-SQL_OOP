using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Udemy_Web_C_
{
    public partial class Form1 : Form
    {
        string firstNum = "";
        bool firstVal = false;
        string secondNum = "";
        //bool secondVal = false;
        string mathOperator = "";
        bool multiNum = false;
        public Form1()
        {
            InitializeComponent();
        }

        public void SetLabels()
        {
            label1.Text = $"First Number: {firstNum}";
            label2.Text = $"Second Number: {secondNum}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            firstVal = false;
            mathOperator = "";
            textBox1.Text = "";
            firstNum = "";
            secondNum = "";
            multiNum = false;
            SetLabels();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (firstVal == false)
            {
                mathOperator = "+";
                textBox1.Text = "";
                firstVal = true;
                SetLabels();
            }
            else
            {
                if (mathOperator == "+")
                {
                    firstNum = (Convert.ToDouble(firstNum) + Convert.ToDouble(secondNum)).ToString();
                    textBox1.Text = firstNum.ToString();
                    multiNum = true;
                    SetLabels();
                }
                else
                {
                    mathOperator = "+";
                }
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (firstVal == false)
            {
                mathOperator = "-";
                textBox1.Text = "";
                firstVal = true;
                SetLabels();
            }
            else
            {
                if (mathOperator == "-")
                {
                    firstNum = (Convert.ToDouble(firstNum) - Convert.ToDouble(secondNum)).ToString();
                    textBox1.Text = firstNum.ToString();
                    multiNum = true;
                    SetLabels();
                }
                else
                {
                    mathOperator = "-";
                }
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (firstVal == false)
            {
                mathOperator = "*";
                textBox1.Text = "";
                firstVal = true;
                SetLabels();
            }
            else
            {
                if (mathOperator == "*")
                {
                    firstNum = (Convert.ToDouble(firstNum) * Convert.ToDouble(secondNum)).ToString();
                    textBox1.Text = firstNum.ToString();
                    multiNum = true;
                    SetLabels();
                }
                else
                {
                    mathOperator = "*";
                }
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (firstVal == false)
            {
                mathOperator = "/";
                textBox1.Text = "";
                firstVal = true;
                SetLabels();
            }
            else
            {
                if (mathOperator == "/")
                {
                    firstNum = (Convert.ToDouble(firstNum) / Convert.ToDouble(secondNum)).ToString();
                    textBox1.Text = firstNum.ToString();
                    multiNum = true;
                    SetLabels();
                }
                else
                {
                    mathOperator = "/";
                }
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (mathOperator == "+")
            {
                mathOperator = "+";
                firstNum = (Convert.ToDouble(firstNum) + Convert.ToDouble(secondNum)).ToString();
                textBox1.Text = firstNum.ToString();
                multiNum = true;
                SetLabels();
            }
            else if (mathOperator == "-")
            {
                mathOperator = "-";
                firstNum = (Convert.ToDouble(firstNum) - Convert.ToDouble(secondNum)).ToString();
                textBox1.Text = firstNum.ToString();
                multiNum = true;
                SetLabels();
            }
            else if (mathOperator == "*")
            {
                mathOperator = "*";
                firstNum = (Convert.ToDouble(firstNum) * Convert.ToDouble(secondNum)).ToString();
                textBox1.Text = firstNum.ToString();
                multiNum = true;
                SetLabels();
            }
            else if (mathOperator == "/")
            {
                mathOperator = "/";
                firstNum = (Convert.ToDouble(firstNum) / Convert.ToDouble(secondNum)).ToString();
                textBox1.Text = firstNum.ToString();
                multiNum = true;
                SetLabels();
            }
            else
            {
                MessageBox.Show("Error: Invalid math operator");
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (firstVal == false)
            {
                firstNum += "1";
                textBox1.Text = firstNum.ToString();
                SetLabels();
            }
            else 
            {
                if (multiNum == true)
                {
                    secondNum = "1";
                    multiNum = false;
                    textBox1.Text = secondNum.ToString();
                    SetLabels();
                }
                else
                {
                    secondNum += "1";
                    textBox1.Text = secondNum.ToString();
                    SetLabels();
                }
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (firstVal == false)
            {
                firstNum += "2";
                textBox1.Text = firstNum.ToString();
                SetLabels();
            }
            else
            {
                if (multiNum == true)
                {
                    secondNum = "2";
                    multiNum = false;
                    textBox1.Text = secondNum.ToString();
                    SetLabels();
                }
                else
                {
                    secondNum += "2";
                    textBox1.Text = secondNum.ToString();
                    SetLabels();
                }
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (firstVal == false)
            {
                firstNum += "3";
                textBox1.Text = firstNum.ToString();
                SetLabels();
            }
            else
            {
                if (multiNum == true)
                {
                    secondNum = "3";
                    multiNum = false;
                    textBox1.Text = secondNum.ToString();
                    SetLabels();
                }
                else
                {
                    secondNum += "3";
                    textBox1.Text = secondNum.ToString();
                    SetLabels();
                }
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (firstVal == false)
            {
                firstNum += "4";
                textBox1.Text = firstNum.ToString();
                SetLabels();
            }
            else
            {
                if (multiNum == true)
                {
                    secondNum = "4";
                    multiNum = false;
                    textBox1.Text = secondNum.ToString();
                    SetLabels();
                }
                else
                {
                    secondNum += "4";
                    textBox1.Text = secondNum.ToString();
                    SetLabels();
                }
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (firstVal == false)
            {
                firstNum += "5";
                textBox1.Text = firstNum.ToString();
                SetLabels();
            }
            else
            {
                if (multiNum == true)
                {
                    secondNum = "5";
                    multiNum = false;
                    textBox1.Text = secondNum.ToString();
                    SetLabels();
                }
                else
                {
                    secondNum += "5";
                    textBox1.Text = secondNum.ToString();
                    SetLabels();
                }
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (firstVal == false)
            {
                firstNum += "6";
                textBox1.Text = firstNum.ToString();
                SetLabels();
            }
            else
            {
                if (multiNum == true)
                {
                    secondNum = "6";
                    multiNum = false;
                    textBox1.Text = secondNum.ToString();
                    SetLabels();
                }
                else
                {
                    secondNum += "6";
                    textBox1.Text = secondNum.ToString();
                    SetLabels();
                }
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (firstVal == false)
            {
                firstNum += "7";
                textBox1.Text = firstNum.ToString();
                SetLabels();
            }
            else
            {
                if (multiNum == true)
                {
                    secondNum = "7";
                    multiNum = false;
                    textBox1.Text = secondNum.ToString();
                    SetLabels();
                }
                else
                {
                    secondNum += "7";
                    textBox1.Text = secondNum.ToString();
                    SetLabels();
                }
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (firstVal == false)
            {
                firstNum += "8";
                textBox1.Text = firstNum.ToString();
                SetLabels();
            }
            else
            {
                if (multiNum == true)
                {
                    secondNum = "8";
                    multiNum = false;
                    textBox1.Text = secondNum.ToString();
                    SetLabels();
                }
                else
                {
                    secondNum += "8";
                    textBox1.Text = secondNum.ToString();
                    SetLabels();
                }
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (firstVal == false)
            {
                firstNum += "9";
                textBox1.Text = firstNum.ToString();
                SetLabels();
            }
            else
            {
                if (multiNum == true)
                {
                    secondNum = "9";
                    multiNum = false;
                    textBox1.Text = secondNum.ToString();
                    SetLabels();
                }
                else
                {
                    secondNum += "9";
                    textBox1.Text = secondNum.ToString();
                    SetLabels();
                }
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (firstVal == false)
            {
                firstNum += "0";
                textBox1.Text = firstNum.ToString();
                SetLabels();
            }
            else
            {
                if (multiNum == true)
                {
                    secondNum = "0";
                    multiNum = false;
                    textBox1.Text = secondNum.ToString();
                    SetLabels();
                }
                else
                {
                    secondNum += "0";
                    textBox1.Text = secondNum.ToString();
                    SetLabels();
                }
            }
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (firstVal == false)
            {
                if (!firstNum.Contains("."))
                {
                    if (firstNum.Length == 0)
                    {
                        firstNum = "0.";
                    }
                    else 
                    {
                        firstNum += ".";
                    }                    
                    textBox1.Text = firstNum.ToString();
                    SetLabels();
                }                
            }
            else
            {
                if (multiNum == true)
                {
                    secondNum = "0.";
                    multiNum = false;
                    textBox1.Text = secondNum.ToString();
                    SetLabels();
                }
                else
                {
                    if (!secondNum.Contains(".")) 
                    {
                        if (secondNum.Length == 0)
                        {
                            secondNum += "0.";
                        }
                        else
                        {
                            secondNum += ".";
                        }                        
                        textBox1.Text = secondNum.ToString();
                        SetLabels();
                    }                    
                }
            }
        }
    }
}
