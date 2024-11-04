using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Udemy_Web_C_
{
    public class Employee2
    {
        public int employeeID { get; set; }
        public string employeeName { get; set; }
        public double employeeSalary { get; set; }
        public string employeePosition { get; set; }

        public virtual string SetValues(int ID, string name, double salaray)
        {
            employeeID = ID;
            employeeName = name;
            employeeSalary = salaray;

            string text = "Employee ID: " + employeeID + Environment.NewLine;
            text += "Employee Name: " + employeeName + Environment.NewLine;
            text += "Employee Salary: " + employeeSalary + Environment.NewLine;
            return text;
        }
    }    
}
