using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string textValue = "";
        public delegate void fillTextBox(int x);
        public void fillMethod(int examNode)
        {
            textValue = "Your text value is: " + examNode + Environment.NewLine;
        }
        public void ShowText()
        {
            textOutput.Text = textValue;
        }
        public void fillChemestry(int examNode)
        {
            textValue += "Your Chemestry Value is: " + examNode + Environment.NewLine;
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            fillTextBox fillText = new fillTextBox(fillMethod);
            fillText += fillChemestry;
            fillText(60);
            fillText -= fillMethod;
            fillText(30);
            ShowText();
        }
    }
}
