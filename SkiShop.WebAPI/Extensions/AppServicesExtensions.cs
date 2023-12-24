using SkiShop.Domain;
using SkiShop.Application.Handlers.Commands;
using SkiShop.Application.Data;

namespace SkiShop.WebAPI.Extensions
{
    public static class AppServicesExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(CreateProductCommandHandler).Assembly));
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
