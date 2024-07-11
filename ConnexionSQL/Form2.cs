using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnexionSQL
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void butInsert_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee(0,
                firstNameBox.Text, lastNameBox.Text, emailBox.Text, phoneNumberBox.Text,
                DateTime.Parse(hireDateBox.Text), Int32.Parse(jobIdBox.Text), Double.Parse(salaryBox.Text), 
                Int32.Parse(managerIdBox.Text), Int32.Parse(departmentIdBox.Text));

            EmployeeDAL empDAL = new EmployeeDAL();
            empDAL.Insert(emp);
            this.Close();
        }
    }
}
