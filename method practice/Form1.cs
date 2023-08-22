using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace method_practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void hideRadioButtons()
        {
            groupBox1.Visible = false;
        }
        public void clearAllText()
        {
            textBox1.Clear();
            textBox2.Clear();
        }
        public string theName()
        {
            string name = "Liyana";
            return name;
        }
        public int sum(int x, int y)
        {
            x = Convert.ToInt32(textBox1.Text);
            y = Convert.ToInt32(textBox2.Text);
            return x + y;
        
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            hideRadioButtons();
            //clearAllText();
            moveText(textBox1.Text);
            changeNumber(33);
              
            
        }
        private void changeNumber(int age)
        {
            label1.Text = "you are " + age + " years old";
        }
        private void moveText(string text)
        {
            textBox2.Text = text;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
