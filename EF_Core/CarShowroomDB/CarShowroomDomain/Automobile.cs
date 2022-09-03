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
        public List<CarShowroom> CarShowrooms { get; set; }
        public List<Avaibility> Avaibilities { get; set; }
        public Brand Brand { get; set; }
        public int BrandId { get; set; }

        public Model Model { get; set; }
        public int ModelId { get; set; }

        public Equipment Equipment { get; set; }
        public int EquipmentId { get; set; }

        public Automobile()
        {
            Orders = new List<Order>();
            CarShowrooms = new List<CarShowroom>();
            Avaibilities = new List<Avaibility>();
        }
    }
}
