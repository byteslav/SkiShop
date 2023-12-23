using MediatR;

namespace SkiShop.Application.Commands
{
    public sealed record CreateProductCommand(
        string Name,
        string Description,
        decimal Price) : IRequest;
}
