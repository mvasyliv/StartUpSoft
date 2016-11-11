using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lesson2HomeTask.Models;

namespace Lesson2HomeTask.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<ApplicationUser> users = new List<ApplicationUser>();
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                users = db.Users.ToList();
            }

            return View(users);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}