﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PubContext;

#nullable disable

namespace CarShowroomDBData.Migrations
{
    [DbContext(typeof(CarShowroomContext))]
    [Migration("20220903143557_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CarShowroomDomain.Automobile", b =>
                {
                    b.Property<string>("VIN")
                        .HasMaxLength(17)
                        .HasColumnType("nvarchar(17)");

                    b.Property<string>("BodyType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EquipmentId")
                        .HasColumnType("int");

                    b.Property<int>("ModelId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ProdDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 9, 3, 17, 35, 56, 794, DateTimeKind.Local).AddTicks(7261));

                    b.HasKey("VIN");

                    b.HasIndex("BrandId");

                    b.HasIndex("EquipmentId");

                    b.HasIndex("ModelId");

                    b.ToTable("Automobiles");
                });

            modelBuilder.Entity("CarShowroomDomain.Avaibility", b =>
                {
                    b.Property<int>("CarShowroomId")
                        .HasColumnType("int");

                    b.Property<string>("VINAuto")
                        .HasColumnType("nvarchar(17)");

                    b.HasKey("CarShowroomId", "VINAuto");

                    b.HasIndex("VINAuto");

                    b.ToTable("Avaibilities");
                });

            modelBuilder.Entity("CarShowroomDomain.Brand", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BrandId"), 1L, 1);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("BrandId");

                    b.HasIndex("CompanyName");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("CarShowroomDomain.CarShowroom", b =>
                {
                    b.Property<int>("CarShowroomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarShowroomId"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("House")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CarShowroomId");

                    b.ToTable("CarShowroom");
                });

            modelBuilder.Entity("CarShowroomDomain.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClientId"), 1L, 1);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("ClientId");

                    b.ToTable("Clients");

                    b.HasCheckConstraint("CK_Clients_Email", "Email LIKE '%@%.%'");

                    b.HasCheckConstraint("CK_Clients_Phone", "Phone LIKE '(0[0-9][0-9]) [0-9][0-9][0-9]-[0-9][0-9]-[0-9][0-9]'");
                });

            modelBuilder.Entity("CarShowroomDomain.Company", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SiteComp")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Name");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("CarShowroomDomain.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"), 1L, 1);

                    b.Property<int>("HeadManagerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.HasIndex("HeadManagerId")
                        .IsUnique();

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("CarShowroomDomain.Engine", b =>
                {
                    b.Property<int>("EngineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EngineId"), 1L, 1);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("EngineCapacity")
                        .HasColumnType("float");

                    b.Property<string>("FuelType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Power")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("EngineId");

                    b.HasIndex("CompanyName");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Engines");
                });

            modelBuilder.Entity("CarShowroomDomain.Equipment", b =>
                {
                    b.Property<int>("EquipmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EquipmentId"), 1L, 1);

                    b.Property<int>("EngineId")
                        .HasColumnType("int");

                    b.Property<string>("Gearbox")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ModelId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<string>("Transmission")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EquipmentId");

                    b.HasIndex("EngineId");

                    b.HasIndex("ModelId");

                    b.ToTable("Equipments");
                });

            modelBuilder.Entity("CarShowroomDomain.Model", b =>
                {
                    b.Property<int>("ModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ModelId"), 1L, 1);

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProdYearFrom")
                        .HasColumnType("int");

                    b.Property<string>("ProdYearTo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ModelId");

                    b.HasIndex("BrandId");

                    b.ToTable("Models");
                });

            modelBuilder.Entity("CarShowroomDomain.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"), 1L, 1);

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 9, 3, 17, 35, 56, 796, DateTimeKind.Local).AddTicks(2506));

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PurchaseDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VinAuto")
                        .IsRequired()
                        .HasColumnType("nvarchar(17)");

                    b.HasKey("OrderId");

                    b.HasIndex("ClientId");

                    b.HasIndex("VinAuto");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("CarShowroomDomain.Worker", b =>
                {
                    b.Property<int>("WorkerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WorkerId"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int?>("DepartmentId1")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("money");

                    b.HasKey("WorkerId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("DepartmentId1");

                    b.ToTable("Workers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Worker");

                    b.HasCheckConstraint("CK_Workers_Phone", "Phone LIKE '(0[0-9][0-9]) [0-9][0-9][0-9]-[0-9][0-9]-[0-9][0-9]'");

                    b.HasCheckConstraint("CK_Workers_Salary", "Salary > 0");
                });

            modelBuilder.Entity("CarShowroomWorker", b =>
                {
                    b.Property<int>("CarShowroomsCarShowroomId")
                        .HasColumnType("int");

                    b.Property<int>("WorkersWorkerId")
                        .HasColumnType("int");

                    b.HasKey("CarShowroomsCarShowroomId", "WorkersWorkerId");

                    b.HasIndex("WorkersWorkerId");

                    b.ToTable("CarShowroomWorker");
                });

            modelBuilder.Entity("OrderWorker", b =>
                {
                    b.Property<int>("OrdersOrderId")
                        .HasColumnType("int");

                    b.Property<int>("WorkersWorkerId")
                        .HasColumnType("int");

                    b.HasKey("OrdersOrderId", "WorkersWorkerId");

                    b.HasIndex("WorkersWorkerId");

                    b.ToTable("OrderWorker");
                });

            modelBuilder.Entity("CarShowroomDomain.HeadManager", b =>
                {
                    b.HasBaseType("CarShowroomDomain.Worker");

                    b.Property<int>("ManagedDepartmentId")
                        .HasColumnType("int");

                    b.HasIndex("ManagedDepartmentId");

                    b.HasDiscriminator().HasValue("HeadManager");

                    b.HasCheckConstraint("CK_Workers_Phone", "Phone LIKE '(0[0-9][0-9]) [0-9][0-9][0-9]-[0-9][0-9]-[0-9][0-9]'");

                    b.HasCheckConstraint("CK_Workers_Salary", "Salary > 0");
                });

            modelBuilder.Entity("CarShowroomDomain.Automobile", b =>
                {
                    b.HasOne("CarShowroomDomain.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarShowroomDomain.Equipment", "Equipment")
                        .WithMany()
                        .HasForeignKey("EquipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarShowroomDomain.Model", "Model")
                        .WithMany()
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Equipment");

                    b.Navigation("Model");
                });

            modelBuilder.Entity("CarShowroomDomain.Avaibility", b =>
                {
                    b.HasOne("CarShowroomDomain.CarShowroom", "CarShowroom")
                        .WithMany("Avaibilities")
                        .HasForeignKey("CarShowroomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarShowroomDomain.Automobile", "Automobile")
                        .WithMany("Avaibilities")
                        .HasForeignKey("VINAuto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Automobile");

                    b.Navigation("CarShowroom");
                });

            modelBuilder.Entity("CarShowroomDomain.Brand", b =>
                {
                    b.HasOne("CarShowroomDomain.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("CarShowroomDomain.Department", b =>
                {
                    b.HasOne("CarShowroomDomain.HeadManager", "HeadManager")
                        .WithOne()
                        .HasForeignKey("CarShowroomDomain.Department", "HeadManagerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("HeadManager");
                });

            modelBuilder.Entity("CarShowroomDomain.Engine", b =>
                {
                    b.HasOne("CarShowroomDomain.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyName");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("CarShowroomDomain.Equipment", b =>
                {
                    b.HasOne("CarShowroomDomain.Engine", "Engine")
                        .WithMany()
                        .HasForeignKey("EngineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarShowroomDomain.Model", "Model")
                        .WithMany()
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Engine");

                    b.Navigation("Model");
                });

            modelBuilder.Entity("CarShowroomDomain.Model", b =>
                {
                    b.HasOne("CarShowroomDomain.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("CarShowroomDomain.Order", b =>
                {
                    b.HasOne("CarShowroomDomain.Client", "Client")
                        .WithMany("Orders")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarShowroomDomain.Automobile", "Automobile")
                        .WithMany("Orders")
                        .HasForeignKey("VinAuto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Automobile");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("CarShowroomDomain.Worker", b =>
                {
                    b.HasOne("CarShowroomDomain.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CarShowroomDomain.Department", null)
                        .WithMany("Workers")
                        .HasForeignKey("DepartmentId1");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("CarShowroomWorker", b =>
                {
                    b.HasOne("CarShowroomDomain.CarShowroom", null)
                        .WithMany()
                        .HasForeignKey("CarShowroomsCarShowroomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarShowroomDomain.Worker", null)
                        .WithMany()
                        .HasForeignKey("WorkersWorkerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OrderWorker", b =>
                {
                    b.HasOne("CarShowroomDomain.Order", null)
                        .WithMany()
                        .HasForeignKey("OrdersOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarShowroomDomain.Worker", null)
                        .WithMany()
                        .HasForeignKey("WorkersWorkerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CarShowroomDomain.HeadManager", b =>
                {
                    b.HasOne("CarShowroomDomain.Department", "ManagedDepartment")
                        .WithMany()
                        .HasForeignKey("ManagedDepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ManagedDepartment");
                });

            modelBuilder.Entity("CarShowroomDomain.Automobile", b =>
                {
                    b.Navigation("Avaibilities");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("CarShowroomDomain.CarShowroom", b =>
                {
                    b.Navigation("Avaibilities");
                });

            modelBuilder.Entity("CarShowroomDomain.Client", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("CarShowroomDomain.Department", b =>
                {
                    b.Navigation("Workers");
                });
#pragma warning restore 612, 618
        }
    }
}
