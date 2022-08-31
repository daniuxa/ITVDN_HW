using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CarShowroomDomain
{
    public class Automobile
    {
        [Key]
        [MaxLength(17)]
        [MinLength(17)]
        public string VIN { get; set; }
        public DateTime ProdDate { get; set; }
        public string BodyType { get; set; }
        public string Color { get; set; }
        public List<Order> Orders { get; set; }
    }
}
