using azurelinuxapp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace azurelinuxapp.Controllers

{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext dBContext)
        {
            _context = dBContext;
        }
        public ActionResult Index()
        {

            return View(_context.Books.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                _context.Books.Add(book);
                _context.SaveChanges();
                return View("Index", _context.Books.ToList());
            }
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(_context.Books.Find(id));
        }
        [HttpPost]
        public ActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                var dbbook = _context.Books.FirstOrDefault(x => x.Id == book.Id);
                dbbook.Name = book.Name;
                dbbook.cost = book.cost;
                dbbook.description = book.description;
                _context.Books.Update(dbbook);
                _context.SaveChanges();
                return View("Index",_context.Books.ToList());
            }
            return View();
        }
        [HttpGet]
        [ActionName("Delete")]
        public ActionResult Delete_Get(int id)
        {

            var dbbook = _context.Books.Find(id);
            return View(dbbook);
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult Delete_Post(int id)
        {
            var dbbook = _context.Books.Find(id);
            _context.Books.Remove(dbbook);
            return View("Index");
        }
    }
}
