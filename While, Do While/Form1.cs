using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While__Do_While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int loopWorkAmount = 0, loopControlValue = 10;
            while (loopControlValue < 20)
            {
                loopWorkAmount++;
                loopControlValue++;
                textBox1.Text += loopWorkAmount.ToString() + Environment.NewLine;
            }
            MessageBox.Show(loopWorkAmount.ToString());
        }
             
       

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            int loopWorkAmount = 0, loopControlValue = 10;
            do
            {
                loopWorkAmount++;
                loopControlValue++;
                textBox1.Text = loopWorkAmount.ToString() + Environment.NewLine;
            } while (loopControlValue < 20);
            MessageBox.Show(loopWorkAmount.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int inloopWorkAmount = 0, inloopControlValue = 0;
            int outloopWorkAmount = 0, outloopControlValue = 10;
            while(inloopControlValue < 20)
            {
                inloopControlValue = 0;
                while (inloopControlValue < 8)
                {
                    inloopWorkAmount++;
                    inloopControlValue++;
                    textBox1.Text = outloopControlValue.ToString() + " " + inloopControlValue.ToString() + Environment.NewLine;
                }
                outloopWorkAmount++;
                outloopControlValue++;
            }
            MessageBox.Show("outLoopWorkAmount works" + outloopWorkAmount.ToString() +
                "times inloopWorkAmount works" + inloopWorkAmount.ToString() + Environment.NewLine);
        }
    }
}
