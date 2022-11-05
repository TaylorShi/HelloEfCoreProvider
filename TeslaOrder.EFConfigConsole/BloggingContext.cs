using Microsoft.EntityFrameworkCore;
using TeslaOrder.Domain.AggregatesModel;

namespace TeslaOrder.EFConfigConsole
{
    public class BloggingContext : DbContext
    {
        public BloggingContext(DbContextOptions<BloggingContext> options)
                : base(options)
        {
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        public string DbPath { get; }
    }
}
