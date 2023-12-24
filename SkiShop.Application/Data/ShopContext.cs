using Microsoft.EntityFrameworkCore;
using SkiShop.Domain.Entities.Products;

namespace SkiShop.Application.Data
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {

        }

        public DbSet<Product> Products => Set<Product>();
    }
}
