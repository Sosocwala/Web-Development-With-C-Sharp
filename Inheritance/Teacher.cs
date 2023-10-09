using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Teacher : Employee
    {
        public string Branch { get; set; }

        public void findSalary()
        {
            Salary = 2000;
        }
       public void setValue2()
        {
            position = "Director";
            Branch = "Water&Sanitation";
        }
    }
}
