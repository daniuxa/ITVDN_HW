using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroomDomain
{
    public class HeadManager : Worker
    {
        public Department ManagedDepartment { get; set; }
        [ForeignKey("ManagedDepartment")]
        public int ManagedDepartmentId { get; set; }
        public string Email { get; set; }
    }
}
