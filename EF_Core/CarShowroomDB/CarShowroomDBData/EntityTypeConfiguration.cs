using CarShowroomDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroomDBData
{
    public class ClientEntityTypeConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasCheckConstraint("CK_Clients_Phone", "Phone LIKE '(0[0-9][0-9]) [0-9][0-9][0-9]-[0-9][0-9]-[0-9][0-9]'");
            builder.HasCheckConstraint("CK_Clients_Email", "Email LIKE '%@%.%'");
        }
    }

    public class OrderEntityTypeConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(x => x.OrderDateTime).HasDefaultValue(DateTime.Now);
        }
    }

    public class AutomobileEntityTypeConfiguration : IEntityTypeConfiguration<Automobile>
    {
        public void Configure(EntityTypeBuilder<Automobile> builder)
        {
            builder.Property(x => x.ProdDate).HasDefaultValue(DateTime.Now);
            builder.HasMany(x => x.CarShowrooms).WithMany(y => y.Automobiles).UsingEntity<Avaibility>
                (b => b.HasOne(x => x.CarShowroom).WithMany(y => y.Avaibilities).HasForeignKey(x => x.CarShowroomId),
                a => a.HasOne(x => x.Automobile).WithMany(y => y.Avaibilities).HasForeignKey(x => x.VINAuto));
            builder.HasOne(x => x.Model).WithMany().OnDelete(DeleteBehavior.Restrict);
        }
    }
    public class WorkerEntityTypeConfiguration : IEntityTypeConfiguration<Worker>
    {
        public void Configure(EntityTypeBuilder<Worker> builder)
        {
            builder.HasCheckConstraint("CK_Workers_Phone", "Phone LIKE '(0[0-9][0-9]) [0-9][0-9][0-9]-[0-9][0-9]-[0-9][0-9]'");
            builder.HasCheckConstraint("CK_Workers_Salary", "Salary > 0");
            builder.HasOne(x => x.Department).WithMany().HasForeignKey("DepartmentId").OnDelete(DeleteBehavior.Restrict);
        }
    }

    public class DepartmentEntityTypeConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasOne(x => x.HeadManager).WithMany().OnDelete(DeleteBehavior.Restrict);
        }
    }

    public class AvaibilityEntityTypeConfiguration : IEntityTypeConfiguration<Avaibility>
    {
        public void Configure(EntityTypeBuilder<Avaibility> builder)
        {
            builder.HasKey(x => new { x.CarShowroomId, x.VINAuto });
            /*builder.HasOne(x => x.CarShowroom).WithMany(y => y.Avaibilities).HasForeignKey(x => x.CarShowroomId);
            builder.HasOne(x => x.Automobile).WithMany(y => y.Avaibilities).HasForeignKey(x => x.VINAuto);*/
        }
    }

    public class BrandEntityTypeConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasIndex(x => x.Name).IsUnique();
        }
    }
    public class EngineEntityTypeConfiguration : IEntityTypeConfiguration<Engine>
    {
        public void Configure(EntityTypeBuilder<Engine> builder)
        {
            builder.HasIndex(x => x.Name).IsUnique();
            builder.Property(x => x.Power).HasDefaultValue(0);
        }
    }

    public class EquipmentEntityTypeConfiguration : IEntityTypeConfiguration<Equipment>
    {
        public void Configure(EntityTypeBuilder<Equipment> builder)
        {
            builder.HasOne(x => x.Model).WithMany().OnDelete(DeleteBehavior.Restrict);
        }
    }

}
