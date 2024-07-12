using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnexionSQL
{
    internal class EmployeeDAL
    {
        private DBConnection connection;
        
        public EmployeeDAL()
        {
            this.connection = new DBConnection();
        }


        public void Insert(Employee employee)
        {
            connection.OpenConnection();

            if (connection.Status() == "Open")
            {
                MessageBox.Show(GetInsertionQuery("Employees", employee));   
                connection.ExecuteQuery(GetInsertionQuery("Employees", employee));
                MessageBox.Show("Inserción exitosa");
                connection.CloseConnection();
            }
            else
                MessageBox.Show("Connection could not be opened");
        }
        private string GetInsertionQuery(string tableName, Employee employee)
        {
            Type type = typeof(Employee);
            FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            string text = $" INSERT INTO {tableName}(";

            foreach (var field in fields)
            {
                if (field.Name != "employee_id")
                    text += $"{field.Name}, ";
            }

            text = text.Remove(text.Length - 1); // eliminamos el backspace
            text = text.Remove(text.Length - 1); // eliminamos la ultima coma
            text += ") VALUES (";

            foreach (var field in fields) // obtenemos los campos del objeto
            {
                if (field.Name != "employee_id")
                {
                    //  no tiene que llevar comillas si es un numero
                    if (field.FieldType == typeof(int) || field.FieldType == typeof(double))
                        text += $"{field.GetValue(employee)}" + ",";
                    else
                        text += $"'{field.GetValue(employee)}'" + ",";
                }
            }

            text = text.Remove(text.Length - 1); // eliminamos la última coma
            text += ")";
            return text;
        }

        public List<Employee> SelectAll()
        {
            connection.OpenConnection();
            SqlCommand command = connection.ExecuteQuery("SELECT * FROM EMPLOYEES");

            List<Employee> employees = new List<Employee>();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read()) // mientras haya cosas que leer
            {
                Employee employee = new Employee();

                employee.EmployeeId = reader.GetInt32(reader.GetOrdinal("employee_id"));
                employee.FirstName = reader.IsDBNull(reader.GetOrdinal("first_name")) ? null : reader.GetString(reader.GetOrdinal("first_name"));
                employee.LastName = reader.GetString(reader.GetOrdinal("last_name"));
                employee.Email = reader.GetString(reader.GetOrdinal("email"));
                employee.PhoneNumber = reader.IsDBNull(reader.GetOrdinal("phone_number")) ? null : reader.GetString(reader.GetOrdinal("phone_number"));
                employee.HireDate = reader.GetDateTime(reader.GetOrdinal("hire_date"));
                employee.JobId = reader.GetInt32(reader.GetOrdinal("job_id"));
                employee.Salary = reader.GetDecimal(reader.GetOrdinal("salary"));
                
                if (!reader.IsDBNull(reader.GetOrdinal("manager_id")))
                    employee.ManagerId = reader.GetInt32(reader.GetOrdinal("job_id"));

                if (!reader.IsDBNull(reader.GetOrdinal("department_id")))
                    employee.DepartmentId = reader.GetInt32(reader.GetOrdinal("department_id"));

                
                employees.Add(employee);
            }
            reader.Close();
            connection.CloseConnection();

            return employees;
        }
    }
}
