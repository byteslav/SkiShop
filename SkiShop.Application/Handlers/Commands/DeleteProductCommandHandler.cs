using MediatR;
using SkiShop.Domain;

namespace SkiShop.Application.Handlers.Commands
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand>
    {
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteProductCommandHandler(IProductRepository productRepository, IUnitOfWork unitOfWork)
        {
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(DeleteProductCommand command, CancellationToken cancellationToken)
        {
            _productRepository.Delete(command.Id);

            await _unitOfWork.CompleteAsync();
        }
    }
}
