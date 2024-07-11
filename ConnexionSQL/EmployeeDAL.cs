using System;
using System.Collections.Generic;
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

        public void Select(string query)
        {

        }
    }
}
