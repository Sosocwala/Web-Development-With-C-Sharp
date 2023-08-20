using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counting_Numbers_Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int fistNumber = 0, lastNumber = 0;
      
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDivisibleNumber.Items.Add("2");
            cmbDivisibleNumber.Items.Add("3");
            cmbDivisibleNumber.Items.Add("4");
            cmbDivisibleNumber.Items.Add("5");
            cmbDivisibleNumber.Items.Add("6");
            cmbDivisibleNumber.Items.Add("7");
            cmbDivisibleNumber.Items.Add("8");
            cmbDivisibleNumber.Items.Add("9");
            cmbDivisibleNumber.Items.Add("10");
        }
        int divisibleTerm = 0;
        private void cmbDivisibleNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            divisibleTerm = Convert.ToInt32(cmbDivisibleNumber.SelectedIndex);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (rbYellow.Checked)
            {
                rbBlue.Checked = false;
                rbGreen.Checked = false;
                rbOrange.Checked = false;
                rbRed.Checked = false;
                textOutput.ForeColor = Color.Yellow
            }
        }

        private void rbRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRed.Checked)
            {
                rbBlue.Checked = false;
                rbGreen.Checked = false;
                rbOrange.Checked = false;
                rbYellow.Checked = false;
                textOutput.ForeColor = Color.Red;
            }
        }

        private void rbBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBlue.Checked)
            {
                rbRed.Checked = false;
                rbGreen.Checked = false;
                rbOrange.Checked = false;
                rbYellow.Checked = false;
                textOutput.ForeColor = Color.Blue;
            }
        }

        private void rbGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGreen.Checked)
            {
                rbBlue.Checked = false;
                rbRed.Checked = false;
                rbOrange.Checked = false;
                rbYellow.Checked = false;
                textOutput.ForeColor = Color.Green;
            }
        }

        private void rbOrange_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOrange.Checked)
            {
                rbBlue.Checked = false;
                rbGreen.Checked = false;
                rbRed.Checked = false;
                rbYellow.Checked = false;
                textOutput.ForeColor = Color.Orange;
            }
        }

        private void textFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {

            int controlnumber = 1;
            string divisibleNumber = "";
            if (textFrom.Text.Trim() == "" && textTo.Text.Trim() == "")
            {
                MessageBox.Show("Please fill in the necersarry fields");
            }
            else if(cmbDivisibleNumber.SelectedIndex == - 1)
            {
                MessageBox.Show("Please set the Divisible");
            }
            else
            {
                fistNumber = Convert.ToInt32(textFrom.Text);
                lastNumber = Convert.ToInt32(textTo.Text);
                for (int i = fistNumber; i < lastNumber; i++)
                {

                    if (i % divisibleTerm == 0)
                    {
                        divisibleNumber += i.ToString() + " ";
                        if (controlnumber % 10 == 0)
                            divisibleNumber += Environment.NewLine;
                        controlnumber++;
                    }

                }
                textOutput.Text = divisibleNumber;
            }
        }
    }
}
