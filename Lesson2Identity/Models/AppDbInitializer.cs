
using System.Data.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Lesson2Identity.Models
{
    public class AppDbInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            var userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(context));
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            // create 2 new roles
            var role1 = new IdentityRole { Name = "admin"};
            var role2 = new IdentityRole {Name = "user"};

            // add role to database
            roleManager.Create(role1);
            roleManager.Create(role2);

            // create users
            var admin = new ApplicationUser {Email = "vmv_gaz@yahoo.com", UserName="vmv1", Age = 50};
            string password = "vmv1_VMV";
            var result = userManager.Create(admin, password);
            // if user created ok
            if (result.Succeeded)
            {
                // add role to user
                userManager.AddToRole(admin.Id, role1.Name);
                userManager.AddToRole(admin.Id, role2.Name);
            }

            // new user
            var u1 = new ApplicationUser {Email="vmv@ukr.net", Age = 50, UserName = "vmv@ukr.net"};
            string pwd = "vmv1_VMV1";
            var r = userManager.Create(u1, pwd);
            if (r.Succeeded)
            {
                // add role to user
                userManager.AddToRole(u1.Id, role1.Name);
                userManager.AddToRole(u1.Id, role2.Name);
            }
            base.Seed(context);
        }
    }
}