using Microsoft.AspNetCore.Mvc;
using ViewComponentsPartialMvc.DataAccessLayer;

namespace ViewComponentsPartialMvc.Controllers
{
    public class ProductController:Controller
    {
        private readonly AppDbContext _context;
        private readonly int _productCount;
        public ProductController(AppDbContext context)
        {
            _context = context;
            ViewBag.ProductCount = _context.Products.Count();
        }
        public IActionResult Index()
        {
            var products = _context.Products.Take(4).ToList();
            return View(products);
        }
        public IActionResult LoadProductsOnProducts(int skip)
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
