using System;
using System.Collections.Generic;

namespace ScaffoldingTest
{
    public partial class Book
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int PublishingYear { get; set; }
        public int? AuthorsId { get; set; }

        public virtual Author? Authors { get; set; }
    }
}
