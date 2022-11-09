using CarShowroomDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace CarShowroomDbData
{
    public class CarShowroomContext : DbContext
    {
        public DbSet<Client> Clients { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Automobile> Automobiles { get; set; } = null!;
        public DbSet<Worker> Workers { get; set; } = null!;
        public DbSet<Department> Departments { get; set; } = null!;
        public DbSet<Avaibility> Avaibilities { get; set; } = null!;
        public DbSet<Company> Companies { get; set; } = null!;
        public DbSet<Brand> Brands { get; set; } = null!;
        public DbSet<Engine> Engines { get; set; } = null!;
        public DbSet<Model> Models { get; set; } = null!;
        public DbSet<Equipment> Equipments { get; set; } = null!;
        public DbSet<HeadManager> HeadManagers { get; set; } = null!;

        private StreamWriter streamWriter = new StreamWriter("InfoLogs.log", append: false);

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var configuration = new ConfigurationBuilder().AddUserSecrets<CarShowroomContext>().Build();
            //var connectionString = configuration.GetConnectionString("CarShowroom");
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            var config = builder.Build();
            string? connectionString = config.GetConnectionString("MyConnection");

            optionsBuilder.UseSqlServer(connectionString!).
                LogTo(streamWriter.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information).
                EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CarShowroomContext).Assembly);
            /*modelBuilder.Entity<Company>().HasData(
                new Company[]
                {
                    new Company() { Name = "VAG", SiteComp = "vag-group.com" },
                    new Company() { Name = "Toyota", SiteComp = "Toyota.com" },
                    new Company() { Name = "Honda", SiteComp = "Honda.com" }
                });*/
        }
        public override void Dispose()
        {
            streamWriter.Dispose();
            base.Dispose();
        }
    }
}