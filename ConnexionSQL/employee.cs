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
        private double salary;
        private int manager_id;
        private int department_id;

        public Employee(int employee_id, string first_name, 
            string last_name, string email, string phone_number, 
            DateTime hire_date, int job_id, double salary, int manager_id, 
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

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public int ManagerId
        {
            get { return manager_id; }
            set { manager_id = value; }
        }

        public int DepartmentId
        {
            get { return department_id; }
            set { department_id = value; }
        }
    }
}
