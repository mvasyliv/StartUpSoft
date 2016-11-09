
using System.Data.Entity;

namespace MvcMovie.Models
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext()
            :base("MovieDBContextServer")
        {
        }
        public MovieDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}