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

namespace DirectoryUsing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(@"Temp"))
            {
                Directory.CreateDirectory(@"Temp");
            }
            DirectoryInfo ddr = new DirectoryInfo("@Temp2");
            string accessTime = ddr.LastAccessTime.ToString();
            MessageBox.Show(accessTime);
            ddr.Create();
            MessageBox.Show("Folder has been creating"); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Directory.Move("@Temp", @"D:\@Temp");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Directory.Delete("@Temp2");
        }
    }
}
