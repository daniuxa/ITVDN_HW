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
        //Key
        public string VIN { get; set; }

        public DateTime ProdDate { get; set; }
        public string BodyType { get; set; }
        public string Color { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();
        
        //Relation directly to CarShowoom table
        public List<CarShowroom> CarShowrooms { get; set; } = new List<CarShowroom>();
        //Relation through the table Avaibility to CarShowroomtable 
        public List<Avaibility> Avaibilities { get; set; } = new List<Avaibility>();

        public Brand Brand { get; set; }
        public int BrandId { get; set; }

        public Model Model { get; set; }
        public int ModelId { get; set; }

        public Equipment Equipment { get; set; }
        public int EquipmentId { get; set; }
    }
}
