using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Development_With_C_Sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 20, b = 30;
            string name = "Sopie";
            bool control = true;
             if(a == 20)
            {
                label1.Text = "If Block 1 was executed";
            }
            if (!control)
            {
                textBox1.Text = "if Block 2 was executed";
            }
            if (a <= b)
            {
               MessageBox.Show("if Block 3 was executed");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 20, b = 30;
            string name = "Soso";
            bool control = true;
            if (a == 30)
            {
                textBox1.Text = "if Block 1 was executed";
            }
            else if (control)
            {
                textBox1.Text = "if block 2 was executed";
            }
            else if (a >= b)
            {
                textBox1.Text = "if block 3 was executed";
            }
            else
            {
                textBox1.Text = "if block 4 was executed";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to abort", "if control", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                textBox1.Text = "Yes is selected";
            }
            else if (result == DialogResult.No)
            {
                textBox1.Text = "No was selected";
            }
            else
            {
                textBox1.Text = "Cancel was Selected";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = 20, b = 30;
            string ternaryResults;
            ternaryResults = a < b ? b.ToString() : a.ToString();
            MessageBox.Show(ternaryResults);
        }
    }
}
