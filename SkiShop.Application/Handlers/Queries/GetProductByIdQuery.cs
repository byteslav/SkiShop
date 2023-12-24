using MediatR;
using SkiShop.Domain.Entities.Products;

namespace SkiShop.Application.Handlers.Queries
{
    public sealed record GetProductByIdQuery(int Id) : IRequest<Product>;
}
