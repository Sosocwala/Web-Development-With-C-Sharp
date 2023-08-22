using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Working_Practise
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
        int firstNumber = 0, lastNumber = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDivisibleNumbers.Items.Add("0");
            cmbDivisibleNumbers.Items.Add("1");
            cmbDivisibleNumbers.Items.Add("2");
            cmbDivisibleNumbers.Items.Add("3");
            cmbDivisibleNumbers.Items.Add("4");
            cmbDivisibleNumbers.Items.Add("5");
            cmbDivisibleNumbers.Items.Add("6");
            cmbDivisibleNumbers.Items.Add("7");
            cmbDivisibleNumbers.Items.Add("8");
            cmbDivisibleNumbers.Items.Add("9");
            cmbDivisibleNumbers.Items.Add("10");
        }
        int divisibleTerm = 1;
        private void cmbDivisibleNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            divisibleTerm = Convert.ToInt32(cmbDivisibleNumbers.SelectedIndex);
        }
        string divisibleNumber = "";
        int controlNumber = 1;

        private void textStartFrom_KeyPress(object sender, KeyPressEventArgs e)
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            if (textStartFrom.Text.Trim() == "" || textTo.Text.Trim() == "")
            {
                MessageBox.Show("please enter the nessecery fields");
            }
            else if (cmbDivisibleNumbers.SelectedIndex == -1)
            {
                MessageBox.Show("please select the divisible");
            }
            else
            {
            firstNumber = Convert.ToInt32(textStartFrom.Text);
            lastNumber = Convert.ToInt32(textTo.Text);
            MessageBox.Show("Divisible" + divisibleTerm + " From " + firstNumber + " To " + lastNumber);
                for (int i = firstNumber; i < lastNumber; i++)
                {
                    if (i % divisibleTerm == 0)
                    {
                        divisibleNumber += i.ToString() + " ";
                        if (divisibleTerm % 10 == 0)
                            divisibleNumber += Environment.NewLine;
                        controlNumber++;
                    }
                    textOutput.Text = divisibleNumber;
                }
            }
        }
    }
}
