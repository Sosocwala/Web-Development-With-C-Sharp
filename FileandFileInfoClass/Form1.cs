using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileandFileInfoClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!File.Exists(@"File1"))
            {
                File.Create(@"File1");
                MessageBox.Show("File has been Created!");
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            File.Delete(@"File1");
            MessageBox.Show("File has been Deleted");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnWrite_Click(object sender, EventArgs e)
        {
            FileStream fileWrite = new FileStream(@"File1.text", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter TextWriter = new StreamWriter(fileWrite);
            TextWriter.WriteLine("This is my first writimg in a file");
            TextWriter.WriteLine("This here is a stamp to show that im here to stay");
            TextWriter.Flush();
            TextWriter.Close();
        }
       private void btnRead_Click(object sender, EventArgs e)
        {
            FileStream fileReader = new FileStream(@"File1.text", FileMode.Open, FileAccess.Read);
            StreamReader TextReader = new StreamReader(fileReader);
            string text = "";
            while (!TextReader.EndOfStream)
            {
                text += TextReader.ReadLine() + Environment.NewLine;
            }
            fileReader.Close();
            TextReader.Close();
            textOutput.Text = text;
            
        }
    }
}
