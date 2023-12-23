namespace SkiShop.Domain.Entities.Products
{
    public class Product : BaseEntity
    {
        public Product(int id, string name, string description, decimal price)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
