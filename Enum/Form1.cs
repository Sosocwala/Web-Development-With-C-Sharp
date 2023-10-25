using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        enum color { red, blue = 4, orange, pink, yellow = 10, purple, white };
        private void btnSend_Click(object sender, EventArgs e)
        {
            string text = "Red: " + (int)color.red + Environment.NewLine;
            text += "Blue: " + (int)color.blue + Environment.NewLine;
            text += "Orange: " + (int)color.orange + Environment.NewLine;
            text += "Pink: " + (int)color.pink + Environment.NewLine;
            text += "Yellow: " + (int)color.yellow + Environment.NewLine;
            text += "Purple: " + (int)color.purple + Environment.NewLine;
            text += "White: " + (int)color.white + Environment.NewLine;
            textOutput.Text = text;
        }
    }
}
