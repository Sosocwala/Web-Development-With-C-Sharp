using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
   public class Employee
    {
        public int employeeID { get; set; }
        public string employeeName { get; set; }
        public string employeeSurname { get; set; }
        public int employeeSalary { get; set; }

        public void setValue(int ID)
        {
            employeeID = ID;
        }
        public void setValue(int ID, string name)
        {
            employeeID = ID;
            employeeName = name;
        }
        public void setValue(int ID, string name,string surname)
        {
            employeeID = ID;
            employeeName = name;
            employeeSurname = surname;
        }
        public void setValue(int ID, string name, string surname,int salary)
        {
            employeeID = ID;
            employeeName = name;
            employeeSurname = surname;
            employeeSalary = salary;
        }
    }
}
