using Microsoft.AspNetCore.Mvc;
using ViewComponentsPartialMvc.DataAccessLayer;

namespace ViewComponentsPartialMvc.Controllers
{
    public class ProductController:Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

    }
}
