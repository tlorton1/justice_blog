using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace JusticeWebApp.Data
{
    public class PostContext : DbContext
    {
        public PostContext() : base("DefaultConnection")
        {

        }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<Reply> Replies { get; set; }
    }
}