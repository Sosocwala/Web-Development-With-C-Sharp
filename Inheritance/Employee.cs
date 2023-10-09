using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Employee : Human
    {
        public string position { get; set; }
        public decimal Salary { get; set; }

        public void setValue()
        {
            ID = 12345234;
            name = "Mango";
            surname = "Suthu";
            Gender = 'M';
            Age = 34;
        }
    }
}
