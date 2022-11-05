using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace TeslaOrder.EFConfigConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddDbContext<BloggingContext>(opt => opt.UseSqlServer("Server=tcp:127.0.0.1,1433;Database=TeslaOrder.EFConfigConsole;User Id=sa;Password=beE#Yahlj!Sdgj6x;"));

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
