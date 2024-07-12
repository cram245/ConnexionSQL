using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnexionSQL
{
    internal class Department
    {
        private int departmentId;
        private string departmentName;
        private int? locationId;

        public Department() { }
        public int DepartmentID { get => departmentId; set => departmentId = value; }
        public string DepartmentName { get => departmentName; set => departmentName = value; }
        public int LocationID { get => (int)locationId; set => locationId = value; }
    }
}
