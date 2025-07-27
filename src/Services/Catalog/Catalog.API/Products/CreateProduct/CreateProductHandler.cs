using BuildingBlocks.CQRS;
using Catalog.API.Models;

namespace Catalog.API.Products.CreateProduct
{
    public record CreateProductCommand(string Name, List<string> Categotry, string Description, string ImageFile, decimal Price)
    : ICommand<CreateProductResult>;
    public record CreateProductResult(Guid Id);

    internal class CreateProductCommandHandler
        : ICommandHandler<CreateProductCommand, CreateProductResult>
    {
        public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {

            // Business logic to create a product would go here.
            // Here you would typically interact with a database or a service to create the product.    

            var product = new Product
            {
                Name = command.Name,
                Category = command.Categotry,
                Description = command.Description,
                ImageFile = command.ImageFile,
                Price = command.Price
            };

            //save the database
            //return result


            return new CreateProductResult(Guid.NewGuid()); // Simulating product creation with a new Guid for demonstration purposes.
        }
       
    }
}
