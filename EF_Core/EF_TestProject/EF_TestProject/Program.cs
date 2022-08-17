using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

using var dbContext = new ApplicationContext();

dbContext.Database.ExecuteSqlRaw("SELECT 1");

Console.WriteLine();
Console.WriteLine($"Имя провайдера БД: {dbContext.Database.ProviderName}.");
Console.WriteLine();

public class ApplicationContext : DbContext
{
   // public DbSet<User> Users => Set<User>();
    public ApplicationContext() => Database.EnsureCreated();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // подключаемся к MS SQL Server БД, используя указанную строку подключения
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
                LogLevel.Information);
    }
}