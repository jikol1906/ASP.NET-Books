using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ConsoleApp.SQLite.Models;

namespace ConsoleApp.SQLite.Controllers
{
    public class HomeController : Controller
    {
        BookContext db = new BookContext();
        

        public IActionResult Index()
        {
            db.Books.Add(new Book{Name="Title",Author="Author"});

            db.SaveChanges();

            return View(db.Books);
        }

        public IActionResult Delete()
        {
            

            return View();
        }

        public IActionResult addBook()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
