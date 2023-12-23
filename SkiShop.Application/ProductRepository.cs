using SkiShop.Domain;
using SkiShop.Domain.Entities.Products;

namespace SkiShop.Application
{
    public class ProductRepository : IProductRepository
    {
        private readonly ShopContext _context;

        public ProductRepository(ShopContext context)
        {
            _context = context;
        }

        public void Add(Product product)
        {
            _context.Products.Add(product);
        }
    }
}
