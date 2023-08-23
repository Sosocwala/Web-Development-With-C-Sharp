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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Employees personelDetails = new Employees();
        private void btnSetValue_Click(object sender, EventArgs e)
        {
            personelDetails.employeeID = Convert.ToInt32(textID.Text);
            personelDetails.name = textName.Text;
            personelDetails.age = Convert.ToInt32(textAge.Text);
            MessageBox.Show("Information captured");  

        }

        private void btnSendValue_Click(object sender, EventArgs e)
        {
            personelDetails.employeeID = Convert.ToInt32(textID.Text);
            personelDetails.name = textName.Text;
            personelDetails.age = Convert.ToInt32(textAge.Text);
            Form2 form2 = new Form2();
            form2.personeDetails = personelDetails;
            form2.ShowDialog();
        }
    }
}
