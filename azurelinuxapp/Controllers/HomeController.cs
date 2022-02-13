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
        public ActionResult Test()
        {

            return View();
        }

        public string Sample()
        {

            return "Sample code";
        }
    }
}
