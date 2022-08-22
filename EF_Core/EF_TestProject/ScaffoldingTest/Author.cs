using System;
using System.Collections.Generic;

namespace ScaffoldingTest
{
    public partial class Author
    {
        public Author()
        {
            Books = new HashSet<Book>();
        }

        public int Id { get; set; }
        public string Fname { get; set; } = null!;
        public string? Lname { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
