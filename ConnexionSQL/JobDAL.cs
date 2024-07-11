using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnexionSQL
{
    internal class JobDAL
    {
        private DBConnection connection;

        public JobDAL()
        {
            connection = new DBConnection();
        }


        public List<Job> SelectAll()
        {
            connection.OpenConnection();
            SqlCommand command = connection.ExecuteQuery("SELECT * FROM JOBS");

            List<Job> jobs = new List<Job>();
            SqlDataReader reader = command.ExecuteReader();
            
            while (reader.Read()) // mientras haya cosas que leer
            {
                Job job = new Job();

                job.JobId = reader.GetInt32(reader.GetOrdinal("job_id"));
                job.JobTittle = reader.GetString(reader.GetOrdinal("job_tittle"));

                if (!reader.IsDBNull(reader.GetOrdinal("min_salary")))
                    job.MinSalary = reader.GetDecimal(reader.GetOrdinal("min_salary"));
                if (!reader.IsDBNull(reader.GetOrdinal("max_salary")))
                    job.MaxSalary = reader.GetDecimal(reader.GetOrdinal("max_salary"));
                
                jobs.Add(job);
            }
            reader.Close();
            connection.CloseConnection();

            return jobs;
        }
    }
}
