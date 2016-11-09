using System.Data.Entity;

namespace BookStoreMetanit.Models
{
    public class BookContext :DbContext
     {
        
         public BookContext()
            :base("BookContext")
         {
             
         }
        public BookContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }
        
        public DbSet<Book> Books { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
    }
}