using Microsoft.EntityFrameworkCore;
using SkiShop.Domain.Entities.Products;

namespace SkiShop.Application
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {

        }

        public DbSet<Product> Products => Set<Product>();
    }
}
