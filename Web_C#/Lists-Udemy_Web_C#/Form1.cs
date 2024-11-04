using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lists_Udemy_Web_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> numberList = new List<int>();
        List<string> textList = new List<string>();
        List<Employee> employeeList = new List<Employee>();

        public List<Employee> FillList() 
        {
            employeeList.Clear();
            Employee employee1 = new Employee();
            employee1.ID = 1;
            employee1.Name = "Charles";
            employee1.surname = "Dickens";
            employeeList.Add(employee1);
            Employee employee2 = new Employee();
            employee2.ID = 2;
            employee2.Name = "Goege";
            employee2.surname = "R.R. Martin";
            employeeList.Add(employee2);
            Employee employee3 = new Employee();
            employee3.ID = 3;
            employee3.Name = "Peter";
            employee3.surname = "Holmes";
            employeeList.Add(employee3);
            Employee employee4 = new Employee();
            employee4.ID = 4;
            employee4.Name = "Jane";
            employee4.surname = "Goodall";
            employeeList.Add(employee4);
            Employee employee5 = new Employee();
            employee5.ID = 5;
            employee5.Name = "James";
            employee5.surname = "Andthegiantpeach";
            employeeList.Add(employee5);
            return employeeList;
        }

        List<Days> comboList = new List<Days>();

        private void Form1_Load(object sender, EventArgs e)
        {
            Days day1 = new Days();
            day1.id = 1;
            day1.textValue = "Sunday";
            comboList.Add(day1);

            Days day2 = new Days();
            day2.id = 2;
            day2.textValue = "Monday";
            comboList.Add(day2);

            Days day3 = new Days();
            day3.id = 3;
            day3.textValue = "Tuesday";
            comboList.Add(day3);

            Days day4 = new Days();
            day4.id = 4;
            day4.textValue = "Wednesday";
            comboList.Add(day4);

            Days day5 = new Days();
            day5.id = 5;
            day5.textValue = "Thursday";
            comboList.Add(day5);

            Days day6 = new Days();
            day6.id = 6;
            day6.textValue = "Friday";
            comboList.Add(day6);

            // Easier way
            comboList.Add(new Days() { id = 7, textValue = "Saturday" });

            cmbDays.DataSource = comboList;
            cmbDays.ValueMember = "ID";
            cmbDays.DisplayMember = "textValue";

            dayList.DataSource = comboList;
        }

        private void btnFillList_Click(object sender, EventArgs e)
        {
            FillList();
            foreach (var item in employeeList) 
            {
                txtNumber.Text += $"ID: {item.ID}, Name: {item.Name} {item.surname}" + Environment.NewLine;
            }
            MessageBox.Show("List was filled!");
        }

        private void cmbDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cmbDays.SelectedValue.ToString());
        }
    }
}
