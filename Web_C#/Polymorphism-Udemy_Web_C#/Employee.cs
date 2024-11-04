using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Udemy_Web_C_
{
    public class Employee
    {
        public int employeeID { get; set; }
        public string employeeName { get; set; }
        public double employeeSalary { get; set; }

        public void SetValues(int ID)
        {
            employeeID = ID;
        }

        public void SetValues(int ID, string name)
        {
            employeeID = ID;
            employeeName = name;
        }

        public void SetValues(int ID, string name, double salaray)
        {
            employeeID = ID;
            employeeName = name;
            employeeSalary = salaray;
        }
    }
}
