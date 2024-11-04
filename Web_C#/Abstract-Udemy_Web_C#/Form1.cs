using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstract_Udemy_Web_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        abstract class Vehicle
        {
            public abstract double GetFuelAmount();
        }

        class Bus : Vehicle
        {
            public override double GetFuelAmount()
            {
                return 300;
            }
        }

        class Truck : Vehicle
        {
            public override double GetFuelAmount()
            {
                return 500;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = "";
            Vehicle vc = new Bus();
            double busFuel = vc.GetFuelAmount();
            text += $"Bus fuel amount is {busFuel.ToString()}" + Environment.NewLine;
            vc = new Truck();
            double truckFuel = vc.GetFuelAmount();
            text += $"Truck fuel amount is {truckFuel.ToString()}" + Environment.NewLine;
            textBox1.Text = text;

        }
    }
}
