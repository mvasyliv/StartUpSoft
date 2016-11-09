using System.Data.Entity;

namespace Lesson1HomeTask.Models
{
    public class DbInitializer : DropCreateDatabaseAlways<Lesson1DbContext>
    {
        protected override void Seed(Lesson1DbContext db)
        {
            db.Posts.Add(new Post {Name = "Test 1", Description = "tests"});
            db.Posts.Add(new Post { Name = "Test 2", Description = "tests 2" });
            db.Posts.Add(new Post { Name = "Test 3", Description = "tests 3" });
            base.Seed(db);
        }
    }
}