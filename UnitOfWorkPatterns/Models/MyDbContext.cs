using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UnitOfWorkPatterns.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
            :base(nameOrConnectionString: "MyDbContext")
        { }

        public DbSet<User> Users { get; set; }

        public DbSet<Post> Posts { get; set; }

    }
}