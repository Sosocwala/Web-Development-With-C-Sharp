using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstract_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        abstract class Vehicle
        {
            public abstract double getFuelAmount();
        }
        class Bus : Vehicle
        {
            public override double getFuelAmount()
            {
                return 20000;
            }
        }
        class Truck : Bus
        {
            public override double getFuelAmount()
            {
                return 4000;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string text = "";
            Vehicle vs;
            vs = new Bus();
            double busFuel = vs.getFuelAmount();
            text += "Bus Fuel Amount is: " + busFuel.ToString() + Environment.NewLine;
            vs = new Truck();
            double truckFuel = vs.getFuelAmount();
            text += "Truck Fuel Amount is: " + truckFuel.ToString() + Environment.NewLine;
            textOutput.Text = text;    
        }
    }
}
