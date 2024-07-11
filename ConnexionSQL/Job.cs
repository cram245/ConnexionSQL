using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnexionSQL
{
    internal class Job
    {
        private int job_id;
        private string job_tittle;
        private decimal? min_salary;
        private decimal? max_salary;

        public Job(int job_id, string job_tittle, decimal min_salary, decimal max_salary)
        {
            this.job_id = job_id;
            this.job_tittle = job_tittle;
            this.min_salary = min_salary;
            this.max_salary = max_salary;
        }
        public Job()
        {
            
        }

        public int JobId { get => job_id; set => job_id = value; }
        public string JobTittle { get => job_tittle; set => job_tittle = value; }
        public decimal MinSalary { get => (decimal)min_salary; set => min_salary = value; }
        public decimal MaxSalary { get => (decimal)max_salary; set => max_salary = value; }
    }
}
