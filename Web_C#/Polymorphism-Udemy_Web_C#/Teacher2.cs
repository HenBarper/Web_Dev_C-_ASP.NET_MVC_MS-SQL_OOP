using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Udemy_Web_C_
{
    internal class Teacher2 : Employee2
    {
        override public string SetValues(int ID, string name, double salaray)
        {
            employeeID = ID;
            employeeName = name;
            employeeSalary = salaray;
            employeePosition = "Teacer";

            string text = "Employee ID: " + employeeID + Environment.NewLine;
            text += "Employee Name: " + employeeName + Environment.NewLine;
            text += "Employee Salary: " + employeeSalary + Environment.NewLine;
            text += "Employee Position: " + employeePosition + Environment.NewLine;
            return text;
        }
    }
}
