using MediatR;

namespace SkiShop.Application.Handlers.Commands
{
    public sealed record DeleteProductCommand(int Id) : IRequest;
}
