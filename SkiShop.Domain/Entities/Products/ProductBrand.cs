namespace SkiShop.Domain.Entities.Products
{
    public class ProductBrand : BaseEntity
    {
        public ProductBrand(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}