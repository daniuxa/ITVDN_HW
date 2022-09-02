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
        [Required]
        public string FName { get; set; }
        [Required]
        public string MName { get; set; }
        [Required]
        public string LName { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        [Column(TypeName ="money")]
        public decimal Salary { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }

        public Department Department { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }

        public List<Order> Orders { get; set; }
        public List<CarShowroom> CarShowrooms { get; set; }
    }
}
