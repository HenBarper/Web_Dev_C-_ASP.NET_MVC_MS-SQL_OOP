using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Udemy_Web_C_
{
    internal class Teacher : Employee
    {
        public string employeePosition { get; set; }

        public void SetValues(int ID, string name, double salaray, string position)
        {
            employeeID = ID;
            employeeName = name;
            employeeSalary = salaray;
            employeePosition = position;
        }

        public string GetValues() 
        {
            string text = "Employee ID: " + employeeID + Environment.NewLine;
            text += "Employee Name: " + employeeName + Environment.NewLine;
            text += "Employee Salary: " + employeeSalary + Environment.NewLine;
            text += "Employee Position: " + employeePosition + Environment.NewLine;
            return text;
        }
    }
}
