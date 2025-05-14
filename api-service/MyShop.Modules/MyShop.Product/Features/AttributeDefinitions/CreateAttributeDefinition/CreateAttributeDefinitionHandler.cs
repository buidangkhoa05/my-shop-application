using KBD5.Shared.Common.Abstractions.Messaging;
using KBD5.Shared.Common.Results;

namespace MyShop.Product.Features.AttributeDefinitions.CreateAttributeDefinition;

public class CreateAttributeDefinitionHandler : ICommandHandler<CreateAttributeDefinitionCommand, CreateAttributeDefinitionResponse>
{
    public Task<Result<CreateAttributeDefinitionResponse>> Handle(CreateAttributeDefinitionCommand request,
        CancellationToken cancellationToken)
    {
        // Simulate some processing logic
        var attributeDefinitionId = Guid.NewGuid().ToString();

        // Return the result
        return Task.FromResult(Result.Success(new CreateAttributeDefinitionResponse(attributeDefinitionId)));
    }
}