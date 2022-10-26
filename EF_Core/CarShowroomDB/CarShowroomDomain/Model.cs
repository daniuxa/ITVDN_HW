using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroomDomain
{
    public class Model
    {
        public int ModelId { get; set; }
        public string Name { get; set; }
        public int ProdYearFrom { get; set; }
        public int ProdYearTo { get; set; }

        public Brand Brand { get; set; }
        public int BrandId { get; set; }

        public List<Equipment> Equipments { get; set; } = new List<Equipment>();
        public List<Automobile> Automobiles { get; set; } = new List<Automobile>();
    }
}
