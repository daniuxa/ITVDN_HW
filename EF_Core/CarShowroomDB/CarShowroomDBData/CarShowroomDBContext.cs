using CarShowroomDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace CarShowroomDbData
{
    public class CarShowroomContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Automobile> Automobiles { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Avaibility> Avaibilities { get; set;}
        public DbSet<Company> Companies { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Engine> Engines { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<HeadManager> HeadManagers { get; set; }

        private StreamWriter streamWriter = new StreamWriter("InfoLogs.log", append: false);

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder().AddUserSecrets<CarShowroomContext>().Build();
            var connectionString = configuration.GetConnectionString("CarShowroom");

            optionsBuilder.UseSqlServer(connectionString).
                LogTo(streamWriter.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information).
                EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CarShowroomContext).Assembly);
        }
        public override void Dispose()
        {
            streamWriter.Dispose();
            base.Dispose();
        }
    }
}