using Microsoft.EntityFrameworkCore;
using SkiShop.Domain;
using SkiShop.Domain.Entities.Products;

namespace SkiShop.Application.Data
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

        public void Delete(int id)
        {
            var productToDelete = _context.Products.Where(p => p.Id == id).FirstOrDefault();

            if (productToDelete == null)
            {
                throw new ArgumentNullException(nameof(productToDelete), $"There is no product with Id = {id}");
            }

            _context.Products.Remove(productToDelete);
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            var products = await _context.Products.ToListAsync();
            return products;
        }

        public async Task<Product> GetById(int id)
        {
            var product = await _context.Products.SingleOrDefaultAsync(product => product.Id == id);

            if (product == null)
            {
                throw new ArgumentNullException(nameof(product), $"There is no product with Id = {id}");
            }

            return product;
        }
    }
}
