using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Practice
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        Employees personelDetails = new Employees();
        private void Form2_Load(object sender, EventArgs e)
        {
            textForm2Id.Text = personelDetails.employeeID.ToString();
            textForm2Name.Text = personelDetails.name;
            textForm2Age.Text = personelDetails.age.ToString();
        }
    }
}
