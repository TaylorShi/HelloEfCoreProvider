using System;
using System.Collections.Generic;
using System.Text;

namespace TeslaOrder.Domain.AggregatesModel
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }

        public string Title { get; set; }

        public string Name { get; set; }

        public List<Post> Posts { get; } = new List<Post>();
    }
}
