using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using TeslaOrder.Domain.AggregatesModel;
using TeslaOrder.Infrastructure.Contexts;

namespace TeslaOrder.EFSqliteProtectedConsole
{
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var folder = Environment.SpecialFolder.MyDocuments;
    //        var path = Environment.GetFolderPath(folder);
    //        var dbPath = System.IO.Path.Join(path, "postting.db");
    //        var dbPassword = "BkBqwG3ps25qQExj";
    //        var connectionString = $"Data Source={dbPath};Password={dbPassword};";

    //        var services = new ServiceCollection();
    //        services.AddDbContext<PosttingContext>(opt => opt.UseSqlite(connectionString));

    //        using (var scope = services.BuildServiceProvider().CreateScope())
    //        {
    //            var context = scope.ServiceProvider.GetService<PosttingContext>();
    //            context.Database.EnsureCreated();

    //            var blog = new Blog
    //            {
    //                BlogId = new Random(16839191).Next(),
    //                Url = "https://www.cnblogs.com/taylorshi/p/16839191.html"
    //            };
    //            context.Add(blog);
    //            context.SaveChanges();

    //            var blogs = context.Blogs.ToList();
    //            if (blogs.Any())
    //            {

    //            }
    //        }

    //        Console.ReadKey();
    //    }
    //}
}
