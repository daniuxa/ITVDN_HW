using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroomDomain
{
    public class Avaibility
    {
        public Automobile Automobile { get; set; }
        public string VINAuto { get; set; }

        public CarShowroom CarShowroom { get; set; }
        public int CarShowroomId { get; set; }
    }
}
