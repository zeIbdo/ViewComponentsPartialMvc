using Microsoft.EntityFrameworkCore;
using ViewComponentsPartialMvc.DataAccessLayer.Entities;

namespace ViewComponentsPartialMvc.DataAccessLayer
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Product>? Products { get; set; }
        public DbSet<Header>? Headers { get; set; }
        public DbSet<Footer>? Footers { get; set; }

    }
}
