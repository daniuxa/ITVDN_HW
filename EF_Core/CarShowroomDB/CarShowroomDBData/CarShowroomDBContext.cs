using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace PubContext
{
    public class CarShowroomContext : DbContext
    {
        private StreamWriter streamWriter = new StreamWriter("log.log", append: false);
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder().AddUserSecrets<CarShowroomContext>().Build();

            Console.WriteLine(configuration.GetDebugView());
            var connectionString = configuration.GetConnectionString("CarShowroom");

            optionsBuilder.UseSqlServer(connectionString).
                LogTo(streamWriter.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information).
                EnableSensitiveDataLogging();
        }
        public override void Dispose()
        {
            streamWriter.Dispose();
            base.Dispose();
        }
    }
}