using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroomDomain
{
    public class CarShowroom
    {
        public int CarShowroomId { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }

        public List<Worker> Workers { get; set; }
        public List<Automobile> Automobiles { get; set; }
        public List<Avaibility> Avaibilities { get; set; }

    }
}
