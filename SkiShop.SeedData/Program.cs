using SkiShop.Application.Data;

namespace SkiShop.SeedData
{
    public class Program
    {
        public async static void Main(string[] args)
        {
            var shopContext = new ShopContext();
            ShopContextSeed.SeedAsync();
        }
    }
}
