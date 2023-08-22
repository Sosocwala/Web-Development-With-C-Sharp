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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        Employee personalDetails = new Employee();
        private void Form2_Load(object sender, EventArgs e)
        {

            textID.Text = personalDetails.employeeId.ToString();
            textName.Text = personalDetails.name;
            textAge.Text = personalDetails.age.ToString();
        }
    }
}
