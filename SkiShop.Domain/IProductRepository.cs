using SkiShop.Domain.Entities.Products;

namespace SkiShop.Domain
{
    public interface IProductRepository
    {
        void Add(Product product);
    }
}
