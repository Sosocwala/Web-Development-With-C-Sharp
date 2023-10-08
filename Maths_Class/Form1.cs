using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maths_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            set1Parameter(textFirstNumber.Text);
            if (!control)
            {
                MessageBox.Show(message);
            }
            else
            {
                textResults.Text = Math.Sign(Convert.ToDecimal(firstNumber)).ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {set1Parameter(textFirstNumber.Text);
            if (!control)
            {
                MessageBox.Show(message);
            }
            else
            {
                double temp = (firstNumber * (Math.PI)) / 180;
                textResults.Text = Math.Cos(temp).ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        double firstNumber = 0, secondNumber = 0;
        bool control = false;
        void set1Parameter(string text)
        {
            if (text.Trim() != "")
            {
                control = true;
                firstNumber = Convert.ToDouble(text);
            }
            else
                control = false;
        }
        void set2Parameter(string text, string text2)
        {
            if (text.Trim() != "" && text2.Trim() != "")
            {
                control = true;
                firstNumber = Convert.ToDouble(text);
                secondNumber = Convert.ToDouble(text2);
            }    

        }
        private void textFirstNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar!='.') && (e.KeyChar!= '-'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            control = false;
            textFirstNumber.Clear();
            textSecondNumber.Clear();
            textResults.Clear();
            firstNumber = 0;
            secondNumber = 0;
        }
        string message = "Plese fill the neccassary area";
        private void btnMin_Click(object sender, EventArgs e)
        {
            set2Parameter(textFirstNumber.Text, textSecondNumber.Text);
            if (!control)
            {
                MessageBox.Show(message);
            }
            else
            {
                textResults.Text = Math.Min(Convert.ToDecimal(firstNumber), Convert.ToDecimal(secondNumber)).ToString();
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            set2Parameter(textFirstNumber.Text, textSecondNumber.Text);
            if (!control)
            {
                MessageBox.Show(message);
            }
            else
            {
                textResults.Text = Math.Max(Convert.ToDecimal(firstNumber), Convert.ToDecimal(secondNumber)).ToString();
            }
        }

        private void btnAbs_Click(object sender, EventArgs e)
        {
            set1Parameter(textFirstNumber.Text);
            if (!control)
            {
                MessageBox.Show(message);
            }
            else
            {
                textResults.Text = Math.Abs(firstNumber).ToString();
            }
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            set1Parameter(textFirstNumber.Text);
            if (!control)
            {
                MessageBox.Show(message);
            }
            else
            {
                double temp = (firstNumber * (Math.PI)) / 180;
                textResults.Text = Math.Sin(temp).ToString();
            }
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            set1Parameter(textFirstNumber.Text);
            if (!control)
            {
                MessageBox.Show(message);
            }
            else 
            {
                double temp = (firstNumber * (Math.PI)) / 180;
                textResults.Text = Math.Tan(temp).ToString();
            }
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            set1Parameter(textFirstNumber.Text);
            if (!control)
                MessageBox.Show(message);
            else
                textResults.Text = Math.Sqrt(firstNumber).ToString();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            set2Parameter(textFirstNumber.Text, textSecondNumber.Text);
            if (!control)
                MessageBox.Show(message);
            else
                textResults.Text = Math.Log(firstNumber, secondNumber).ToString();

        }

        private void textSecondNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
