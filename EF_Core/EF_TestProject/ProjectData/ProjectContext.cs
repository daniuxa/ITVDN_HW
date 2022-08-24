using Microsoft.EntityFrameworkCore;
using ProjectDomain;

namespace ProjectData
{
    public class ProjectContext : DbContext
    {
        public DbSet<Authors> authors { get; set; }
        public DbSet<Books> books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-HAL50HT;Database=Test1;Trusted_Connection=True;");

            #region Detailed connection
            /*// подключаемся к MS SQL Server БД, используя указанную строку подключения
        optionsBuilder
            // настраивает DbContext для подключения к MS SQL Server БД
            .UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=EfCoreBasicDb;Trusted_Connection=True;")
            // включает более детальный вывод ошибок самого EF Core
            .EnableDetailedErrors()
            // включает вывод приватных данных приложения (таких как сгенерированные строки запроса, параметры этих строк запроса)
            .EnableSensitiveDataLogging()
            // логируем всё в консоль
            // также дополнительно отфильтровываем логи, оставляем только запросы в БД
            .LogTo(
                Console.WriteLine,
                new[] { DbLoggerCategory.Database.Command.Name },
                LogLevel.Information);*/
            #endregion
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Authors>().Property(x => x.LName).IsRequired();
        }
    }
}