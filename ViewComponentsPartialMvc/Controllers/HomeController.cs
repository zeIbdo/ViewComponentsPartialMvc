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

    }
}
