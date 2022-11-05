using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using TeslaOrder.Domain.AggregatesModel;

namespace TeslaOrder.Infrastructure.Contexts
{
    public class PosttingContext : DbContext
    {
        public PosttingContext(DbContextOptions<PosttingContext> options)
                : base(options)
        {
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        public string DbPath { get; }
    }
}
