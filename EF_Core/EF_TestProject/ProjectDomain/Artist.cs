using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDomain
{
    public class Artist
    {
        public int ArtistId { get; set; }
        public string FullName { get; set;}
        public List<Work> Works { get; set; }

        public Authors Author { get; set; }

        public Artist()
        {
            Works = new List<Work>();   
        }
    }
}
