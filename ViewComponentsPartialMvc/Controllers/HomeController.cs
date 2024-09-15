using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ViewComponentsPartialMvc.DataAccessLayer;

namespace ViewComponentsPartialMvc.Controllers
{
    public class HomeController:Controller
    {
        private readonly AppDbContext _context;
        private readonly int _productCount;
        public HomeController(AppDbContext context)
        {
            _context = context;
            _productCount = _context.Products.Count();
            ViewBag.ProductCount = _productCount;

        }
        public IActionResult Index()
        {
            var products= _context.Products.Take(4).ToList();
            return View(products);
        }

        public IActionResult LoadProducts(int skip)
        {
            int pageSize = 4;
            var totalProducts = _context.Products.Count();

            if (skip >= totalProducts)
            {
                return BadRequest(); 
            }

            var products = _context.Products.Skip(skip).Take(pageSize).ToList();
            return PartialView("_ProductPartial", products);
        }



    }
}
