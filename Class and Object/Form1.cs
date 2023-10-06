using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_and_Object
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Employee personalDetails = new Employee();
        private void btnSetValue_Click(object sender, EventArgs e)
        {
           
            personalDetails.employeeId = Convert.ToInt32(textEmployeeId.Text);
            personalDetails.name = textName.Text;
            personalDetails.age = Convert.ToInt32(textAge.Text);
            MessageBox.Show("Information captured");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
        
            personalDetails.employeeId = Convert.ToInt32(textEmployeeId.Text);
            personalDetails.name = textName.Text;
            personalDetails.age = Convert.ToInt32(textAge.Text);
            Form2 frmSecond = new Form2();
            frmSecond.personalDetails = personalDetails;
            frmSecond.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
