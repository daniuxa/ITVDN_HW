using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ScaffoldingTest
{
    public partial class Test1Context : DbContext
    {
        public Test1Context()
        {
        }

        public Test1Context(DbContextOptions<Test1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Author> Authors { get; set; } = null!;
        public virtual DbSet<Book> Books { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-HAL50HT;Database=Test1;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>(entity =>
            {
                entity.ToTable("authors");

                entity.Property(e => e.Fname).HasColumnName("FName");

                entity.Property(e => e.Lname).HasColumnName("LName");
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.ToTable("books");

                entity.HasIndex(e => e.AuthorsId, "IX_books_AuthorsId");

                entity.HasOne(d => d.Authors)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.AuthorsId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
