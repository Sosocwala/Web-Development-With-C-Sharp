using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_Case_Statement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string messege = "";
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);
            switch (x)
            {
                case 2:
                    messege = "X = 2";
                    break;
                case 4:
                    messege = "X = 4";
                    break;
                case 6:
                    messege = "X = 6";
                    switch (y)
                    {
                        case 1:
                            messege += " Y = 1";
                            break;
                        case 2:
                            messege += " Y = 2";
                            break;
                        case 3:
                            messege += " Y = 3";
                            break;
                        default:
                            messege += " Y = 8";
                            break;
                    }
                    break;
                default:
                    messege = "X = 8";
                    break;
            }
            MessageBox.Show(messege);
        }
    }
}
