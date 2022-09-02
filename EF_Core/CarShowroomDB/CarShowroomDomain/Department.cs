using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarShowroomDomain
{
    public class Department
    {
        public int DepartmentId { get; set; }
        [Required]
        public string Name { get; set; }

        [ForeignKey("HeadManager")]
        public int HeadManagerId { get; set; }
        public HeadManager HeadManager { get; set; }
        public List<Worker> Workers { get; set; }
    }
}
