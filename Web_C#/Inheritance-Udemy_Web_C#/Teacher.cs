using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Udemy_Web_C_
{
    internal class Teacher : Employee
    {
        public string branch { get; set; }
        public int FindSalary() 
        {
            return 150000;
        }

        public void SetValues2()
        {
            position = "Teacher";
            branch = "Math";
        }
    }
}
