using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Using_Random_Class
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

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random rrnd = new Random();
            byte[] Array = new byte[5];
            rrnd.NextBytes(Array);
            label1.Text = Array[0].ToString();
            label2.Text = Array[1].ToString();
            label3.Text = Array[2].ToString();
            label4.Text = Array[3].ToString();
            label5.Text = Array[4].ToString();
            label6.Text = Array[5].ToString();
  
            /*label1.Text = rrnd.Next(10, 100).ToString();
            label2.Text = rrnd.Next(10, 100).ToString();
            label3.Text = rrnd.Next(10, 100).ToString();
            l abel4.Text = rrnd.Next(10, 100).ToString();
            label5.Text = rrnd.Next(10, 100).ToString();
            label6.Text = rrnd.Next(10, 100).ToString();*/
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnPwd_Click(object sender, EventArgs e)
        {
            var allValid = "cvjhgvqwertyuiop[]1234567890-=\xdx][POIIUYTREWQASDFGHJKL:;'><MNBVCXZ";
            string results = "";
            Random rnd = new Random();
            for (int i = 0; i < 6; i++)
            {
                results += allValid[rnd.Next(0, Convert.ToInt32(allValid.Length))];
            }
            label1.Text = results; 
        }
    }
}
