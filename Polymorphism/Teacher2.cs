﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Teacher2 : employee2
    {
        public override string setValue(int ID, string name, string surname, int salary, string position)
        {
            employeeID = ID;
            employeeName = name;
            employeeSurname = surname;
            employeeSalary = salary;
            employeePosition = position;

            string text = "Employee ID: " + employeeID + Environment.NewLine;
            text += "Employee Name: " + employeeName + Environment.NewLine;
            text += "Employee Surname: " + employeeSurname + Environment.NewLine;
            text += "Employee Salary : " + employeeSalary + Environment.NewLine;
            text += "Employee Position: " + employeePosition + Environment.NewLine;
            return text;
        }
    }
}
