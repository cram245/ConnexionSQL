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

            DepartmentDAL d = new DepartmentDAL();
            comboDepartment.DisplayMember = "DepartmentName";
            comboDepartment.ValueMember = "DepartmentID";
            comboDepartment.DataSource = d.SelectAll();
            comboDepartment.SelectedIndex = 0;

            JobDAL j = new JobDAL();
            comboJob.DisplayMember = "JobTittle";
            comboJob.ValueMember = "JobId";
            comboJob.DataSource = j.SelectAll();
            comboJob.SelectedIndex = 0;

            EmployeeDAL e = new EmployeeDAL();
            comboEmployee.DisplayMember = "FullName";
            comboEmployee.ValueMember = "EmployeeId";
            comboEmployee.DataSource = e.SelectAll().Select(aux => new
            {
                FullName = aux.FirstName + " " + aux.LastName,
                aux.EmployeeId
            }).ToList();
            comboEmployee.SelectedIndex = 0;
        }

        private void butInsert_Click(object sender, EventArgs e)
        {
            Department selectedDepartment = (Department)comboDepartment.Items[comboDepartment.SelectedIndex];
            Job selectedJob = (Job)comboJob.Items[comboJob.SelectedIndex];
            int selectedEmployeeId = (int)comboEmployee.SelectedValue;
            Employee emp = new Employee(0,
                firstNameBox.Text, lastNameBox.Text, emailBox.Text, phoneNumberBox.Text,
                DateTime.Parse(hireDateBox.Text), selectedJob.JobId, Decimal.Parse(salaryBox.Text), 
                selectedEmployeeId, selectedDepartment.DepartmentID);

            
            
            EmployeeDAL empDAL = new EmployeeDAL();
            empDAL.Insert(emp);
            this.Close();
        }

        private void butSelectAll_Click(object sender, EventArgs e)
        {
            EmployeeDAL empDAL = new EmployeeDAL();
            List<Employee> employees = empDAL.SelectAll();

            /*
            foreach (Employee emp in employees)
                listBox1.Items.Add(emp.ToString());
            */

            listBox1.DataSource = employees;
        }
    }
}
