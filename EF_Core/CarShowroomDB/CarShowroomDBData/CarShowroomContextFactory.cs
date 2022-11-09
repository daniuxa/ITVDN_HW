using CarShowroomDbData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroomDBData
{
    public class CarShowroomContextFactory : IDesignTimeDbContextFactory<CarShowroomContext>
    {
        public CarShowroomContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CarShowroomContext>();

            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            IConfigurationRoot config = builder.Build();

            string? connectionString = config.GetConnectionString("MyConnection");
            optionsBuilder.UseSqlServer(connectionString!);
            return new CarShowroomContext(optionsBuilder.Options);
        }
    }
}
