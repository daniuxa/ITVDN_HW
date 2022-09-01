using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroomDomain
{
    public class Order
    {
        public int OrderId { get; set; }

        [Required]
        public DateTime OrderDateTime { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        public string PaymentMethod { get; set; }

        public DateTime PurchaseDateTime { get; set; }

        public Client Client { get; set; }
        [Required]
        public int ClientId { get; set; }

        public string VinAuto { get; set; }
        [ForeignKey("VinAuto")]
        public Automobile Automobile { get; set; }

        public List<Worker> Workers { get; set; }
    }
}
