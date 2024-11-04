using DB_First_demo1.Models;
using Microsoft.AspNetCore.Mvc;

namespace DB_First_demo1.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly BikeStoresContext _context;

        public CategoriesController(BikeStoresContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var categories = _context.Categories.ToList();
            return View(categories);
        }
        public IActionResult Details(int id)
        {
            var categories = _context.Categories.FirstOrDefault(c => c.CategoryId == id);
            if(categories == null)
                return NotFound();
            else
            return View(categories);
        }
    }
}
