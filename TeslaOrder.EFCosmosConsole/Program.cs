using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using TeslaOrder.Domain.AggregatesModel;
using TeslaOrder.Infrastructure.Contexts;

namespace TeslaOrder.EFCosmosConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "AccountEndpoint=https://xxxxxx.documents.azure.com:443/;AccountKey=xxxxxxxxxxxxxxxxxxxxxxxxxxxQB1IDm1DZ5VGHZQwACDbS4IgGA==;";
            var databaseName = "EFCosmosConsole";
            var services = new ServiceCollection();
            services.AddDbContext<BloggingContext>(opt => opt.UseCosmos(connectionString, databaseName));

            using (var scope = services.BuildServiceProvider().CreateScope())
            {
                var context = scope.ServiceProvider.GetService<BloggingContext>();
                //context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                var blog = new Blog
                {
                    BlogId = new Random(99999).Next(),
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
