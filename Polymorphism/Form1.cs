using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Teacher teacher1 = new Teacher();
            teacher1.setValue(12);
            string result = teacher1.getValues();
            textOutput.Text = result;
        }

        private void btnpara2_Click(object sender, EventArgs e)
        {
            Teacher teacher2 = new Teacher();
            teacher2.setValue(12, "Managa");
            string result = teacher2.getValues();
            textOutput.Text = result;
        }

        private void btn2para_Click(object sender, EventArgs e)
        {
            Teacher teacher3 = new Teacher();
            teacher3.setValue(12, "Managa", "Zwelidinga");
            string result = teacher3.getValues();
            textOutput.Text = result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Teacher teacher4 = new Teacher();
            teacher4.setValue(12, "Managa", "Zwelidinga", 20000);
            string result = teacher4.getValues();
            textOutput.Text = result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Teacher teacher5 = new Teacher();
            teacher5.setValue(12, "Managa", "Zwelidinga", 20000, "Admin Clerck");
            string result = teacher5.getValues();
            textOutput.Text = result;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Teacher2 teacher11 = new Teacher2();
            string result = teacher11.setValue(11, "Mlibo", "Zondo", 20000, "Teacher");
            textOutput.Text = result;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            employee2 teacher10 = new employee2();
            string result = teacher10.setValue(11, "Mlibo", "Zondo", 20000);
            textOutput.Text = result;
        }
    }
}
