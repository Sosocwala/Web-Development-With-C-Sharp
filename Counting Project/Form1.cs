using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counting_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int firstNumber = 0, lastNumber = 0;
        
        int controlNumber = 1;
        private void btnCount_Click(object sender, EventArgs e)
        {
            string divisibleNumber = "";
            if (textStartFrom.Text.Trim() == "" || textTo.Text.Trim() == "")
            {
                MessageBox.Show("Plese Fill in the neccessary fields");
            }
            else if (cmbDivisibleTerm.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select divisible term");
            }
            else
            {
                firstNumber = Convert.ToInt32(textStartFrom.Text);
                lastNumber = Convert.ToInt32(textTo.Text);
                MessageBox.Show("Divisible " + divisibleTerm + " From " + firstNumber + " To " + lastNumber);
                for (int i = firstNumber; i < lastNumber; i++)
                {
                    if (i % divisibleTerm == 0)
                    {
                        divisibleNumber += i.ToString() + " ";
                        if (controlNumber % 10 == 0)
                            divisibleNumber += Environment.NewLine
                        controlNumber++;
                    }
                }
                textDivisibleNumbers.Text = divisibleNumber;
            }
        }

        private void cmbDivisibleTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            divisibleTerm = Convert.ToInt32(cmbDivisibleTerm.SelectedItem);
        }
        int divisibleTerm = 1;
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDivisibleTerm.Items.Add("2");
            cmbDivisibleTerm.Items.Add("3");
            cmbDivisibleTerm.Items.Add("4");
            cmbDivisibleTerm.Items.Add("5");
            cmbDivisibleTerm.Items.Add("6");
            cmbDivisibleTerm.Items.Add("7");
            cmbDivisibleTerm.Items.Add("8");
            cmbDivisibleTerm.Items.Add("9");
            cmbDivisibleTerm.Items.Add("10");

        }

        private void textStartFrom_TextChanged(object sender,EventArgs e)
        {
            
        }

        private void textTo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textStartFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void rbBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBlack.Checked)
            {
                rbRed.Checked = false;
                rbOrange.Checked = false;
                rbBlue.Checked = false;
                rbGreen.Checked = false;
                textDivisibleNumbers.ForeColor = Color.Black;
            }
        }

        private void rbRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRed.Checked) 
            {
                rbBlack.Checked = false;
                rbOrange.Checked = false;
                rbBlue.Checked = false;
                rbGreen.Checked = false;
                textDivisibleNumbers.ForeColor = Color.Red;
            }
        }

        private void rbBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBlue.Checked)
            {
                rbRed.Checked = false;
                rbOrange.Checked = false;
                rbBlack.Checked = false;
                rbGreen.Checked = false;
                textDivisibleNumbers.ForeColor = Color.Blue;
            }
        }

        private void rbGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGreen.Checked)
            {
                rbRed.Checked = false;
                rbOrange.Checked = false;
                rbBlue.Checked = false;
                rbBlack.Checked = false;
                textDivisibleNumbers.ForeColor = Color.Green;
            }
        }

        private void rbOrange_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOrange.Checked)
            {
                rbRed.Checked = false;
                rbBlack.Checked = false;
                rbBlue.Checked = false;
                rbGreen.Checked = false;
                textDivisibleNumbers.ForeColor = Color.Orange; 
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
