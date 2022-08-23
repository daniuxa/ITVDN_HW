﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ScaffoldingTest;

#nullable disable

namespace ScaffoldingTest.Migrations
{
    [DbContext(typeof(Test1Context))]
    [Migration("20220823121351_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ScaffoldingTest.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Fname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("FName");

                    b.Property<string>("Lname")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LName");

                    b.HasKey("Id");

                    b.ToTable("authors", (string)null);
                });

            modelBuilder.Entity("ScaffoldingTest.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AuthorsId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PublishingYear")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "AuthorsId" }, "IX_books_AuthorsId");

                    b.ToTable("books", (string)null);
                });

            modelBuilder.Entity("ScaffoldingTest.Book", b =>
                {
                    b.HasOne("ScaffoldingTest.Author", "Authors")
                        .WithMany("Books")
                        .HasForeignKey("AuthorsId");

                    b.Navigation("Authors");
                });

            modelBuilder.Entity("ScaffoldingTest.Author", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
