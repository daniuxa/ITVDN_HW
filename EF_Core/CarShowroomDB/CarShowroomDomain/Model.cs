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
        [Required]
        public string Name { get; set; }
        public int ProdYearFrom { get; set; }
        public string ProdYearTo { get; set; }
        public Brand Brand { get; set; }
        public int BrandId { get; set; }
        public List<Equipment> Equipments { get; set; }

        public Model()
        {
            Equipments = new List<Equipment>();
        }
    }
}
