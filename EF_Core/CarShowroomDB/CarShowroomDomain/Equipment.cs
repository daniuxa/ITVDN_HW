using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroomDomain
{
    public class Equipment
    {
        public int EquipmentId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        public string Gearbox { get; set; }
        public string Transmission { get; set; }
        public Engine Engine { get; set; }
        public int EngineId { get; set; }
        public Model Model { get; set; }
        public int ModelId { get; set; }
    }
}
