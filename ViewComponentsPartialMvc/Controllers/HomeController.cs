using Microsoft.AspNetCore.Mvc;
using ViewComponentsPartialMvc.DataAccessLayer;

namespace ViewComponentsPartialMvc.Controllers
{
    public class HomeController:Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var products= _context.Products.Take(4).ToList();
            return View(products);
        }

        public IActionResult LoadMoreProducts(int page)
        {
            int pageSize = 4; 
            var products = _context.Products
                                   .Skip(page) 
                                   .Take(pageSize)        
                                   .ToList();

            if (!products.Any())
            {
                return Content(""); 
            }

            return PartialView("_ProductPartial", products);
        }


    }
}
