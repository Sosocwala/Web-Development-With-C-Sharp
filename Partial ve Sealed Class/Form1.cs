using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Partial_ve_Sealed_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public partial class Employee
        {
            public int ID { get; set; }
            public string name { get; set; }
            public string surname { get; set; }
            public int age { get; set; }
        }
        public partial class Employee
        {
            public void setValues()
            {
                ID = 123;
                name = "Malabala";
                surname = "Zankonde";
                age = 32;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.setValues();
            string resultText = "";
            resultText += "ID: " + employee.ID.ToString() + Environment.NewLine;
            resultText += "Name: " + employee.name + Environment.NewLine;
            resultText += "Surname: " + employee.surname + Environment.NewLine;
            resultText += "Age: " + employee.age.ToString() + Environment.NewLine;
            textOutput.Text = resultText;  
        }
    }
}
