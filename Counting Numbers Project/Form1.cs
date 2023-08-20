using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counting_Numbers_Project
{
    public partial class divisibleNumber : Form
    {
        public divisibleNumber()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int firstNumber = 0, lastNumber = 0;
        int divisibleTerm = 1;

        private void cmdDivisibleTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            divisibleTerm = Convert.ToInt32(cmdDivisibleTerm.SelectedItem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmdDivisibleTerm.Items.Add("2");
            cmdDivisibleTerm.Items.Add("3");
            cmdDivisibleTerm.Items.Add("4");
            cmdDivisibleTerm.Items.Add("5");
            cmdDivisibleTerm.Items.Add("6");
            cmdDivisibleTerm.Items.Add("7");
            cmdDivisibleTerm.Items.Add("8");
            cmdDivisibleTerm.Items.Add("9");
            cmdDivisibleTerm.Items.Add("10");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        string divisibleNumbers = "";
        int controlNumber = 1;

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
            if (textFrom.Text.Trim() == "" || textTo.Text.Trim() == "")
            {
                MessageBox.Show("please fill in the nessesary fields");
            }
            else if (cmdDivisibleTerm.SelectedIndex == -1)
            {
                MessageBox.Show("Please select divisible term"); 
            }
            else
            {
                firstNumber = Convert.ToInt32(textFrom.Text);
                lastNumber = Convert.ToInt32(textTo.Text);
                for (int i = firstNumber; i < lastNumber; i++)
                {
                    if (i % divisibleTerm == 0)
                    {
                        divisibleNumbers += i.ToString() + " ";
                        if (controlNumber % 10 == 0)
                            divisibleNumbers += Environment.NewLine;
                        controlNumber++;
                    }
                }
                textDivisibleNumber.Text = divisibleNumbers;
            }
        }
    }
}
