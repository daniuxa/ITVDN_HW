using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroomDomain
{
    public class Engine
    {
        public int EngineId { get; set; }
        [Required]
        public string Name { get; set; }
        public double EngineCapacity { get; set; }
        public int Power { get; set; }
        [Required]
        public string FuelType { get; set; }
        public Company Company { get; set; }
        public int CompanyId { get; set; }

    }
}
