using DB_First_demo1.Models;
using Microsoft.AspNetCore.Mvc;

namespace DB_First_demo1.Controllers
{
    public class Products1Controller : Controller
    {
        private readonly BikeStoresContext _context;

        public Products1Controller(BikeStoresContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var products = _context.Products1.ToList();
            return View(products);
        }
    }
}
