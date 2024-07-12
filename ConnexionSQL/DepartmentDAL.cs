using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnexionSQL
{
    internal class DepartmentDAL
    {
        private DBConnection connection;

        public DepartmentDAL()
        {
            connection = new DBConnection();
        }

        public List<Department> SelectAll()
        {
            connection.OpenConnection();
            SqlCommand command = connection.ExecuteQuery("SELECT * FROM DEPARTMENTS");

            List<Department> departments = new List<Department>();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read()) // mientras haya cosas que leer
            {
                Department department = new Department();

                department.DepartmentID = reader.GetInt32(reader.GetOrdinal("department_id"));
                department.DepartmentName = reader.GetString(reader.GetOrdinal("department_name"));


                if (!reader.IsDBNull(reader.GetOrdinal("location_id")))
                    department.LocationID = reader.GetInt32(reader.GetOrdinal("location_id"));
                

                departments.Add(department);
            }
            reader.Close();
            connection.CloseConnection();

            return departments;
        }
    }
}
