using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class employee2
    {
        public int employeeID { get; set; }
        public string employeeName { get; set; }
        public string employeeSurname { get; set; }
        public int employeeSalary { get; set; }
        public string employeePosition { get; set; }

        public virtual string setValue(int ID, string name, string surname, int salary)
        {
            employeeID = ID;
            employeeName = name;
            employeeSurname = surname;
            employeeSalary = salary;

            string text = "Employee ID: " + employeeID + Environment.NewLine;
            text += "Employee Name: " + employeeName + Environment.NewLine;
            text += "Employee Surname: " + employeeSurname + Environment.NewLine;
            text += "Employee Salary : " + employeeSalary + Environment.NewLine;
            return text;
        }
    }
}
