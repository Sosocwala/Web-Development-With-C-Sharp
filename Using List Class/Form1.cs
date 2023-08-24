using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Using_List_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> numberList = new List<int>();
        List<string> textList = new List<string>();
        List<Employee> employeeList = new List<Employee>();
        List<days> comboList = new List<days>();

        public List<Employee> fillList()
        {
            employeeList.Clear();
            Employee employee1 = new Employee();
            employee1.id = 1995;
            employee1.firstName = "Songezo";
            employee1.lastName = "Mseleku";
            employeeList.Add(employee1);
            Employee employee2 = new Employee();
            employee2.id = 1995;
            employee2.firstName = "Bayizoko";
            employee2.lastName = "Qata";
            employeeList.Add(employee2);
            Employee employee3 = new Employee();
            employee3.id = 1995;
            employee3.firstName = "Mongameli";
            employee3.lastName = "Sentu";
            employeeList.Add(employee3);
            return employeeList;
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            days day1 = new days();
            day1.ID = 1;
            day1.tyextValue = "Sunday";
            comboList.Add(day1);
            days day2 = new days();
            day2.ID = 2;
            day2.tyextValue = "Monday";
            comboList.Add(day2);
            days day3 = new days();
            day3.ID = 3;
            day3.tyextValue = "Tuesday";
            comboList.Add(day3);
            days day4 = new days();
            day4.ID = 4;
            day4.tyextValue = "Wednesday";
            comboList.Add(day4);
            days day5 = new days();
            day5.ID = 5;
            day5.tyextValue = "Thursday";
            comboList.Add(day5);
            days day6 = new days();
            day6.ID = 6;
            day6.tyextValue = "Friday";
            comboList.Add(day6);
            comboList.Add(new days() { ID = 7, tyextValue = "Saturday" });
            cmbDays.DataSource = comboList;
            cmbDays.ValueMember = "ID";
            cmbDays.DisplayMember = "textValue";

        }

        private void btnFillList_Click(object sender, EventArgs e)
        {
            fillList();
            foreach (var employee in employeeList)
            {
                textOutput.Text += employee.id + 
                    " " + employee.firstName + " "
                    + employee.lastName +
                    Environment.NewLine;
            } 

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmbDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cmbDays.SelectedValue.ToString()); 
        }
    }
}
