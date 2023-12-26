using SkiShop.Application.Data;
using SkiShop.Domain.Entities.Products;
using System.Text.Json;

namespace SkiShop.SeedData
{
    public class ShopContextSeed
    {
        public static async Task SeedAsync(ShopContext context)
        {
                if (!context.ProductBrands.Any())
                {
                    var brandsData =
                        await File.ReadAllTextAsync("../SkiShop.Application/Data/SeedData/Data/brands.json");
                    var brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandsData);

                    foreach (var item in brands)
                    {
                        context.ProductBrands.Add(item);
                    }

                    await context.SaveChangesAsync();
                }

                if (!context.ProductTypes.Any())
                {
                    var typesData =
                        await File.ReadAllTextAsync("../SkiShop.Application/Data/SeedData/Data/types.json");
                    var types = JsonSerializer.Deserialize<List<ProductType>>(typesData);

                    foreach (var item in types)
                    {
                        context.ProductTypes.Add(item);
                    }

                    await context.SaveChangesAsync();
                }

                if (!context.Products.Any())
                {
                    var productsData =
                        await File.ReadAllTextAsync("../SkiShop.Application/Data/SeedData/Data/products.json");
                    var products = JsonSerializer.Deserialize<List<Product>>(productsData);

                    foreach (var item in products)
                    {
                        context.Products.Add(item);
                    }

                    await context.SaveChangesAsync();
                }
        }
    }
}