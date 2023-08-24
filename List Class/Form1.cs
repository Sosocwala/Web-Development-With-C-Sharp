using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> numberList = new List<int>();
        List<string> textList = new List<string>();
        List<Employee> employeesList = new List<Employee>();
        List<days> comboList = new List<days>();

        public List<Employee> fillList()
        {
            Employee employee1 = new Employee();
            employee1.ID = 1995;
            employee1.firstName = "Sora";
            employee1.lastName = "Gunnz";
            employee1.Age = 20;
            employeesList.Add(employee1);
            Employee employee2 = new Employee();
            employee2.ID = 19921;
            employee2.firstName = "MoMo";
            employee2.lastName = "Vigan";
            employee2.Age = 22;
            employeesList.Add(employee2);
            Employee employee3 = new Employee();
            employee3.ID = 13334;
            employee3.firstName = "Mido";
            employee3.lastName = "Raza";
            employee3.Age = 24;
            employeesList.Add(employee3);
            return employeesList;
        } 
        private void button1_Click(object sender, EventArgs e)
        {
            fillList();
            MessageBox.Show("information recived");
            foreach (var employee in employeesList)
            {
                textOutput.Text += employee.ID.ToString() + 
                    " " + employee.firstName
                    + " " + employee.lastName 
                    + " "+ employee.Age 
                    + Environment.NewLine;
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboList.Add(new days() { dayNum = 1, textValue = "Sunday" });
            comboList.Add(new days() { dayNum = 2, textValue = "Monday" });
            comboList.Add(new days() { dayNum = 3, textValue = "Tuesday" });
            comboList.Add(new days() { dayNum = 4, textValue = "Wednesday" });
            comboList.Add(new days() { dayNum = 5, textValue = "Thursday" });
            comboList.Add(new days() { dayNum = 6, textValue = "Friday" });
            comboList.Add(new days() { dayNum = 7, textValue = "Saturday" });
            cmbDays.DataSource = comboList;
            cmbDays.ValueMember = "dayNum";
            cmbDays.DisplayMember = "textValue";
            gridList.DataSource = comboList;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmbDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
