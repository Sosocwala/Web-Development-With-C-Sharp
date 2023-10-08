using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Employee personalDetails = new Employee();
            personalDetails.name = textName.Text;
            personalDetails.suname = textSurname.Text;
            personalDetails.Age = Convert.ToInt32(textAge.Text);
            personalDetails.cellNumber = Convert.ToInt32(textNumber.Text);
            Form2 ffrm = new Form2();
            ffrm.label2.Text = personalDetails.name;
            ffrm.label3.Text = personalDetails.suname;
            ffrm.label4.Text = personalDetails.Age.ToString();
            ffrm.label5.Text = personalDetails.cellNumber.ToString();
            ffrm.ShowDialog();
            

        }
    }
}
