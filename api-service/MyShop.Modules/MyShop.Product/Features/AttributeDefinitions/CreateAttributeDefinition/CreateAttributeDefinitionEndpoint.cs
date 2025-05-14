using KBD5.Shared.Common.Endpoints;
using KBD5.Shared.Common.Results;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MyShop.Product.Features.AttributeDefinitions.CreateAttributeDefinition;

public class CreateAttributeDefinitionEndpoint : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapPost("/api/attribute-definitions", async (
            [FromBody] CreateAttributeDefinitionCommand command,
            ISender sender) =>
        {
            var result = await sender.Send(command);

            return result.Match(Results.Ok, CustomResults.Problem);
        });
    }
}