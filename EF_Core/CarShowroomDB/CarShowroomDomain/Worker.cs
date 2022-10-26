using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarShowroomDomain
{
    public class Worker
    {
        public int WorkerId { get; set; }
        public string FName { get; set; }
        public string MName { get; set; }
        public string LName { get; set; }
        public string Phone { get; set; }
        public decimal Salary { get; set; }
        public DateTime BirthDate { get; set; }

        public Department Department { get; set; }
        public int DepartmentId { get; set; }

        public List<Department> HeadOfDepartments { get; set; }
        public List<Order> Orders { get; set; }
        public List<CarShowroom> CarShowrooms { get; set; }
    }
}
