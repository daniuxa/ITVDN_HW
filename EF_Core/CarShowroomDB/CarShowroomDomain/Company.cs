using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroomDomain
{
    public class Company
    {
        //Key
        public string Name { get; set; }

        public string? SiteComp { get; set; }

        public List<Engine> Engines { get; set; } = new List<Engine>();
        public List<Brand> Brands { get; set; } = new List<Brand>();
    }
}
