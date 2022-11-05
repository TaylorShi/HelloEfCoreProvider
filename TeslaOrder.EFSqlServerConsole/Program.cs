using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using TeslaOrder.Domain.AggregatesModel;
using TeslaOrder.Infrastructure.Contexts;

namespace TeslaOrder.EFSqlServerConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "Server=tcp:localhost,1433;Database=TeslaOrder.EFSqlServerConsole;User Id=sa;Password=beE#Yahlj!Sdgj6x;";
            var services = new ServiceCollection();
            services.AddDbContext<BloggingContext>(opt => opt.UseSqlServer(connectionString));

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
