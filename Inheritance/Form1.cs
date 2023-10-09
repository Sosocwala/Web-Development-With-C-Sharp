using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.setValue();
            teacher.setValue2();
            teacher.findSalary();
            string allValue = "";
            allValue += teacher.ID + Environment.NewLine;
            allValue += teacher.name + Environment.NewLine;
            allValue += teacher.surname + Environment.NewLine;
            allValue += teacher.Gender + Environment.NewLine;
            allValue += teacher.Age + Environment.NewLine;
            allValue += teacher.position + Environment.NewLine;
            allValue += teacher.Branch + Environment.NewLine;
            allValue += teacher.Salary + Environment.NewLine;
            textOutput.Text = allValue;
        }
    }
}
