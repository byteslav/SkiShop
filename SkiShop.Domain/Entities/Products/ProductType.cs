namespace SkiShop.Domain.Entities.Products
{
    public class ProductType : BaseEntity
    {
        public ProductType(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}