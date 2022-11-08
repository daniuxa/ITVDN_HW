using CarShowroomDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarShowroomDBData
{
    public class ClientEntityTypeConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasCheckConstraint("CK_Clients_Phone", "Phone LIKE '(0[0-9][0-9]) [0-9][0-9][0-9]-[0-9][0-9]-[0-9][0-9]'");
            builder.HasCheckConstraint("CK_Clients_Email", "Email LIKE '%@%.%'");

            builder.Property(x => x.FName).IsRequired();
            builder.Property(x => x.MName).IsRequired();
            builder.Property(x => x.LName).IsRequired();
            builder.Property(x => x.Phone).IsRequired().HasMaxLength(15);
            builder.Property(x => x.Email).IsRequired(false);
        }
    }

    public class OrderEntityTypeConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(x => x.OrderDateTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.OrderDateTime).IsRequired(true);
            builder.Property(x => x.Status).IsRequired(true);
            builder.Property(x => x.PaymentMethod).IsRequired(true);

            //Relation one to many between Automobile - Order and define FK field
            builder.HasOne(x => x.Automobile).WithMany(y => y.Orders).HasForeignKey(z => z.VinAuto).OnDelete(DeleteBehavior.Restrict);   
        }
    }

    public class AutomobileEntityTypeConfiguration : IEntityTypeConfiguration<Automobile>
    {
        public void Configure(EntityTypeBuilder<Automobile> builder)
        {
            builder.HasKey(x => x.VIN);
            builder.Property(x => x.VIN).HasMaxLength(17);
            builder.Property(x => x.ProdDate).HasDefaultValue(DateTime.Now);

            //Create new table Avaibility between many to many relation Automobile - CarShowroom
            builder.HasMany(x => x.CarShowrooms).WithMany(y => y.Automobiles).UsingEntity<Avaibility>
                (b => b.HasOne(x => x.CarShowroom).WithMany(y => y.Avaibilities).HasForeignKey(x => x.CarShowroomId),
                a => a.HasOne(x => x.Automobile).WithMany(y => y.Avaibilities).HasForeignKey(x => x.VINAuto));

            //Relation one to many between Brand - Automobile
            builder.HasOne(x => x.Brand).WithMany(y => y.Automobiles).OnDelete(DeleteBehavior.Restrict);

            //Relation one to many between Model - Automonile
            builder.HasOne(x => x.Model).WithMany(y => y.Automobiles).OnDelete(DeleteBehavior.Restrict);

            //Relation one to many between Equipment - Automobile
            builder.HasOne(x => x.Equipment).WithMany(y => y.Automobiles).OnDelete(DeleteBehavior.Restrict);

            //Relation one to many between Automobile - Order
            builder.HasMany(x => x.Orders).WithOne(y => y.Automobile).OnDelete(DeleteBehavior.Restrict);
        }
    }
    public class WorkerEntityTypeConfiguration : IEntityTypeConfiguration<Worker>
    {
        public void Configure(EntityTypeBuilder<Worker> builder)
        {
            builder.Property(x => x.FName).IsRequired(true);
            builder.Property(x => x.MName).IsRequired(true);
            builder.Property(x => x.LName).IsRequired(true);
            builder.Property(x => x.Phone).IsRequired(true);
            builder.Property(x => x.Salary).IsRequired(true).HasColumnType("money");
            builder.Property(x => x.BirthDate).IsRequired(true);

            builder.HasCheckConstraint("CK_Workers_Phone", "Phone LIKE '(0[0-9][0-9]) [0-9][0-9][0-9]-[0-9][0-9]-[0-9][0-9]'");
            builder.HasCheckConstraint("CK_Workers_Salary", "Salary > 0");

            //Relation one to many between Department - Worker
            builder.HasOne(x => x.Department).WithMany(y => y.Workers).HasForeignKey("DepartmentId").OnDelete(DeleteBehavior.Restrict);
        }
    }

    public class DepartmentEntityTypeConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            //Relation many to many between Worker - Department
            builder.HasMany(x => x.HeadManagers).WithMany(y => y.ManagedDepartments);
            
            //Make unique field
            builder.HasIndex(x => x.Name).IsUnique();
            builder.Property(x => x.Name).IsRequired(true);
        }
    }

    public class AvaibilityEntityTypeConfiguration : IEntityTypeConfiguration<Avaibility>
    {
        public void Configure(EntityTypeBuilder<Avaibility> builder)
        {
            builder.HasKey(x => new { x.CarShowroomId, x.VINAuto });

            //Relation one to many between Automonbile - Avaibility and define FK field in Avaibility
            builder.HasOne(x => x.Automobile).WithMany(y => y.Avaibilities).HasForeignKey(z => z.VINAuto).OnDelete(DeleteBehavior.Restrict);
            
            //Relation one to many between CarShowroom - Avaibility 
            builder.HasOne(x => x.CarShowroom).WithMany(y => y.Avaibilities).OnDelete(DeleteBehavior.Restrict);
        }
    }

    public class BrandEntityTypeConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            //Make unique field
            builder.HasIndex(x => x.Name).IsUnique();
            builder.Property(x => x.Name).IsRequired(true);

            //Relation one to many between Company - Brand
            builder.HasOne(x => x.Company).WithMany(y => y.Brands).OnDelete(DeleteBehavior.Restrict);
        }
    }
    public class EngineEntityTypeConfiguration : IEntityTypeConfiguration<Engine>
    {
        public void Configure(EntityTypeBuilder<Engine> builder)
        {
            builder.HasIndex(x => x.Name).IsUnique();
            builder.Property(x => x.Name).IsRequired(true);
            builder.Property(x => x.FuelType).IsRequired(true);
            builder.Property(x => x.Power).HasDefaultValue(0);

            //Relation one to many between Company - Engine
            builder.HasOne(x => x.Company).WithMany(y => y.Engines).OnDelete(DeleteBehavior.Restrict);
        }
    }

    public class EquipmentEntityTypeConfiguration : IEntityTypeConfiguration<Equipment>
    {
        public void Configure(EntityTypeBuilder<Equipment> builder)
        {
            builder.Property(x => x.Name).IsRequired(true);
            builder.Property(x => x.Price).IsRequired(true).HasColumnType("money");

            //Relation one to many between Equipment - Model
            builder.HasOne(x => x.Model).WithMany(y => y.Equipments).OnDelete(DeleteBehavior.Restrict);

            //Relation one to mane between Equipment - Engine
            builder.HasOne(x => x.Engine).WithMany(y => y.Equipments).OnDelete(DeleteBehavior.Restrict);
        }
    }

    public class CarShowroomEntityTypeConfiguration : IEntityTypeConfiguration<CarShowroom>
    {
        public void Configure(EntityTypeBuilder<CarShowroom> builder)
        {
            builder.Property(x => x.City).IsRequired(true);
            builder.Property(x => x.Street).IsRequired(true);
            builder.Property(x => x.House).IsRequired(true);
        }
    }

    public class CompanyEntityTypeConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasKey(x => x.Name);
            builder.Property(x => x.SiteComp).IsRequired(false);
        }
    }

    public class ModelEntityTypeConfiguration : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.Property(x => x.Name).IsRequired(true);
            builder.Property(x => x.ProdYearTo).IsRequired(false);

            //Relation one to many between Brand - Model
            builder.HasOne(x => x.Brand).WithMany(y => y.Models).OnDelete(DeleteBehavior.Restrict);
        }
    }


    public class HeadManagerEntityTypeConfiguration : IEntityTypeConfiguration<HeadManager>
    {
        public void Configure(EntityTypeBuilder<HeadManager> builder)
        {
            builder.HasMany(x => x.ManagedDepartments).WithMany(y => y.HeadManagers);
        }
    }
}
