using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Lesson1HomeTask.Models
{
    public class Lesson1DbContext : DbContext
    {
        public Lesson1DbContext()
            :base("Lesson1Context")
         {

        }
        public Lesson1DbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }

        public DbSet<Post> Posts { get; set; }
    }
} 