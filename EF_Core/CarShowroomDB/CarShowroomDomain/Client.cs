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
        public string FName { get; set; }
        public string MName { get; set; }
        public string LName { get; set; }
        public string Phone { get; set; }
        public string? Email { get; set; }

        public List<Order> Orders { get; set; } = new List<Order>();
    }
}
