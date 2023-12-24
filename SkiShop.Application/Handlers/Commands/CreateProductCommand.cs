using MediatR;

namespace SkiShop.Application.Handlers.Commands
{
    public sealed record CreateProductCommand(
        string Name,
        string Description,
        decimal Price) : IRequest;
}
