using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learning_Classes_Udemy_Web_C_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Employee personelDetail = new Employee();

        private void Form2_Load(object sender, EventArgs e)
        {
            textEmployeeID.Text = personelDetail.employeeID.ToString();
            textName.Text = personelDetail.name;
            textAge.Text = personelDetail.age.ToString();
        }
    }
}
