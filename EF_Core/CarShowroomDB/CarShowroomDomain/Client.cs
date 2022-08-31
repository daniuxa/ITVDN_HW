using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroomDomain
{
    public class Client
    {
        public int ClientId { get; set; }

        [Required]
        public string FName { get; set; }

        [Required]
        public string MName { get; set; }

        [Required]
        public string LName { get; set; }

        [Required]
        [MaxLength(15)]
        [MinLength(15)]
        public string Phone { get; set; }

        public string? Email { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
