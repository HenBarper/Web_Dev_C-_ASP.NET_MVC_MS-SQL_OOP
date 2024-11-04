using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Udemy_Web_C_
{
    class Employee : Human
    {
        protected string position { get; set; }
        protected double salary { get; set; }

        public void SetValues()
        {
            name = "Charles";
            surName = "Martinet";
            ID = 1;
            gender = 'M';
            age = 30;
        }
    }
}
