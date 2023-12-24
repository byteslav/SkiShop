using MediatR;
using Microsoft.AspNetCore.Mvc;
using SkiShop.Application.Handlers.Commands;
using SkiShop.Application.Handlers.Queries;
using SkiShop.Domain.Entities.Products;

namespace SkiShop.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            var query = new GetProductsQuery();
            return await _mediator.Send(query);
        }

        [HttpGet("{id}")]
        public async Task<Product> Get(int id)
        {
            var query = new GetProductByIdQuery(id);
            return await _mediator.Send(query);
        }

        [HttpPost]
        public async Task Post([FromBody] string name, string description, decimal price)
        {
            var command = new CreateProductCommand(name, description, price);
            await _mediator.Send(command);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public async Task DeleteAsync(int id)
        {
            var command = new DeleteProductCommand(id);
            await _mediator.Send(command);
        }
    }
}
