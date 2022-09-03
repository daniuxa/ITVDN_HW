using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroomDomain
{
    public class Brand
    {
        public int BrandId { get; set; }
        [Required]
        public string Name { get; set; }

        public Company Company { get; set; }
        public int CompanyId { get; set; }

        public List<Model> Models { get; set; }

        public Brand()
        {
            Models = new List<Model>();
        }
    }
}
