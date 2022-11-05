using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using TeslaOrder.Domain.AggregatesModel;
using TeslaOrder.Infrastructure.Contexts;

namespace TeslaOrder.EFPostgreSQLConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "Host=localhost;Port=5432;Database=EFPostgreSQLConsole;Username=postgres;Password=WLqZuwFLy3bBKSJM;Pooling=true;";
            var services = new ServiceCollection();
            services.AddDbContext<BloggingContext>(opt => opt.UseNpgsql(connectionString));

            using (var scope = services.BuildServiceProvider().CreateScope())
            {
                var context = scope.ServiceProvider.GetService<BloggingContext>();
                //context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                var blog = new Blog
                {
                    Url = "https://www.cnblogs.com/taylorshi/p/16843914.html"
                };
                context.Add(blog);
                context.SaveChanges();

                var blogs = context.Blogs.ToList();
                if (blogs.Any())
                {

                }
            }

            Console.ReadKey();
        }
    }
}
