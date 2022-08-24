using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDomain
{
    public class Books
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MyProperty { get; set; }
        public int PublishingYear { get; set; }
        Authors author { get; set; }
        public int AuthorId { get; set; }
    }
}
