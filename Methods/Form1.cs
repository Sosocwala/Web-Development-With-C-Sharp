using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void HideRaidobuttons()
        {
            groupBox1.Visible = false;
        }
        public void fillTextBox(string text)
        {
            textBox2.Text = text;
        }
        public void clearAllText()
        {
            textBox1.Clear();
            textBox2.Clear();
        }
        public void setNumber(int age)
        {
            label1.Text = "You are " + age.ToString() + " years old";
        }
        //string with no parameter but with a return type
        string getName()
        {
            string name = "Sonwa";
            return name;
        }
        int sum(int x, int y)
        {
            int result = x + y;
            return result;
        }
        string valueControl()
        {
            string text = "Inathi";
            return text;
        }
        string valueControl(string name)
        {
            string text = "";
            return text;
        }
        string valueControl(string name, bool control)
        {
            string text = "Liyana";
            return text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HideRaidobuttons();
            //clearAllText();
            fillTextBox(textBox1.Text);
            setNumber(49);
            string name = getName(); 
            MessageBox.Show(name);
            int result = sum(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            MessageBox.Show(result.ToString());
            string names = valueControl("Awomi", true)
            MessageBox.Show(names);

        }
    }
}
