using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using TeslaOrder.Infrastructure.Contexts;

namespace TeslaOrder.EFSqliteConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var folder = Environment.SpecialFolder.MyDocuments;
            var path = Environment.GetFolderPath(folder);
            var DbPath = System.IO.Path.Join(path, "blog.db");

            var services = new ServiceCollection();
            services.AddDbContext<BloggingContext>(opt => opt.UseSqlite($"Data Source={DbPath};Password=BkBqwG3ps25qQExj;"));

            using (var scope = services.BuildServiceProvider().CreateScope())
            {
                var context = scope.ServiceProvider.GetService<BloggingContext>();
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
            }

            Console.ReadKey();
        }
    }
}
