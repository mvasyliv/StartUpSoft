using System;
using System.Collections.Generic;
using System.Web.Mvc;
using BookStoreMetanit.Models;

namespace BookStoreMetanit.Controllers
{
    public class HomeController : Controller
    {
        private BookContext db = new BookContext();
        public ActionResult Index()
        {
            IEnumerable<Book> books = db.Books;
            ViewBag.Books = books;
            return View();
        }
        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.BookId = id;
            return View();
        }
        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            db.Purchases.Add(purchase);
            db.SaveChanges();
            return "Thank you, " + purchase.Person + "!";
        }
    }
}