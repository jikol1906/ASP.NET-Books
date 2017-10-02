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
        
        readonly BookContext db = new BookContext();
        

        public IActionResult Index()
        {
            Console.WriteLine("in Index");
            
            return View(db.Books);
        }

        

        public IActionResult Delete(int id)
        {
            Console.WriteLine("in Delete");
            
            db.Books.Remove(new Book{BookId=id});

            db.SaveChanges();



            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Create(Book b)
        {

//            if (!ModelState.IsValid)
//            {
//                
//            }
//            
            Console.WriteLine("in Create");
            
            db.Add(b);
            db.SaveChanges();
            
            return RedirectToAction("Index");
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult AddBook()
        {
            Console.WriteLine("in AddBook");
            return View();
        }
    }
}
