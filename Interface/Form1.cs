using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        interface Computer
        {
            void getDekstop();
            void getLaptop();
        }
        interface Computers
        {
            void getPrice();
        }
        class DellComputers : Computer, Computers
        {
            public string name { get; set; }
            public string Model { get; set; }
            public int Price { get; set; }
            public void getDekstop()
            {
                name = "Dell";
                Model = "Icore";
            }

           public void getLaptop()
            {
                name = "Mackbook";
                Model = "IoS";
            }
            public void getPrice()
            {
                Price = 2500; 
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        { 

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            DellComputers DellComputer = new DellComputers();
            DellComputer.getDekstop();
            DellComputer.getPrice();
            string allvalues = "Name: " + DellComputer.name + Environment.NewLine;
            allvalues += "Model: " + DellComputer.Model + Environment.NewLine;
            allvalues += "Price: " + DellComputer.Price + Environment.NewLine;
            textOutput.Text = allvalues;
          
        }
    }
}
