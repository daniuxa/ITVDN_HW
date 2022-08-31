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
        }
    }
}
