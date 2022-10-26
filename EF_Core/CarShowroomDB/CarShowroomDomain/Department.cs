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
        public string Name { get; set; }

        public List<Worker> HeadManagers { get; set; }

        public List<Worker> Workers { get; set; }
    }
}
