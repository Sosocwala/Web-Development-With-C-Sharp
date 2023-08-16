using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jump_Statement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ivalue = "";
            for (int i = 0; i < 10; i++)
            {
                if (i == 8)
                    break;
                    ivalue += " " + i + " ";
                
            }
            MessageBox.Show(ivalue);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ivalue = "";
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    continue;
                ivalue += " " + i + " ";
            }
            MessageBox.Show(ivalue);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string imessage = "";
            int x = 3;
            switch (x)
            {
                case 1:
                    imessage = "This is case 1";
                    break;
                case 2:
                    imessage = "This is case 2";
                    break;
                case 3:
                    imessage = "This is case 3";
                    goto case 2;
                default:
                    imessage = "This is case 4";
                    break;
            }
            MessageBox.Show(imessage);

        }
    }
}
