using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDomain
{
    public class Work
    {
        public int WorkId { get; set; }
        public string Name { get; set; }
        public List<Artist> Artists { get; set;}

        public Work()
        {
            Artists = new List<Artist>();
        }
    }
}
