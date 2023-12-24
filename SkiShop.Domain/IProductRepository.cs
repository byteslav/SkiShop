using SkiShop.Domain.Entities.Products;

namespace SkiShop.Domain
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAll();
        Task<Product> GetById(int id);
        void Add(Product product);
        void Delete(int id);
    }
}
