using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConnexionSQL
{
    internal class Employee
    {
        private int employee_id;
        private string first_name;
        private string last_name;
        private string email;
        private string phone_number;
        private DateTime hire_date;
        private int job_id;
        private decimal salary;
        private int? manager_id;
        private int? department_id;

        public Employee(int employee_id, string first_name, 
            string last_name, string email, string phone_number, 
            DateTime hire_date, int job_id, decimal salary, int manager_id, 
            int department_id)
        {
            this.employee_id = employee_id;
            this.first_name = first_name;
            this.last_name = last_name;
            this.email = email;
            this.phone_number = phone_number;
            this.hire_date = hire_date;
            this.job_id = job_id;
            this.salary = salary;
            this.manager_id = manager_id;
            this.department_id = department_id;
        }

        public Employee()
        {

        }

        public int EmployeeId
        {
            get { return employee_id; }
            set { employee_id = value; }
        }

        public string FirstName
        {
            get { return first_name; }
            set { first_name = value; }
        }

        public string LastName
        {
            get { return last_name; }
            set { last_name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string PhoneNumber
        {
            get { return phone_number; }
            set { phone_number = value; }
        }

        public DateTime HireDate
        {
            get { return hire_date; }
            set { hire_date = value; }
        }

        public int JobId
        {
            get { return job_id; }
            set { job_id = value; }
        }

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public int ManagerId
        {
            get { return (int)manager_id; }
            set { manager_id = value; }
        }

        public int DepartmentId
        {
            get { return (int)department_id; }
            set { department_id = value; }
        }

        public override string ToString()
        {
            string text = "";
            text += employee_id.ToString() + " ";
            text += first_name + " ";
            text += last_name + " ";
            text += email + " ";
            text += phone_number + " ";
            text += hire_date.ToString() + " ";
            text += job_id.ToString() + " ";
            text += salary.ToString() + " ";
            text += manager_id.ToString() + " ";
            text += department_id.ToString();

            return text;
        }
    }
}
