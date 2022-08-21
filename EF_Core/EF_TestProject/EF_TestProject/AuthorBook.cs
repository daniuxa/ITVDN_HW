using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_TestProject
{
    internal class Authors
    {
        public int Id { get; set; }
        public string? FName { get; set; }
        public string? LName { get; set; }
        public List<Books>? books { get; set;}

        public Authors()
        {
            books = new List<Books>();
        }
    }

    internal class Books
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PublishingYear { get; set; }
        Authors author { get; set; }
    }
}
