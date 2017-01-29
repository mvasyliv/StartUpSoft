using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Lesson2HomeTask.Models
{
    public class PersonContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
    }
}