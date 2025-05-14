using KBD5.Shared.Common.Abstractions.Messaging;
using KBD5.Shared.Common.Results;
using MyShop.Product.Entities;

namespace MyShop.Product.Features.AttributeDefinitions.CreateAttributeDefinition;

public record CreateAttributeDefinitionCommand : ICommand<CreateAttributeDefinitionResponse>
{
    public string Name { get; set; } = null!;
    public string Unit { get; set; } = null!;
    public string DataType { get; set; } = nameof(AttributeDefinitionDataType.String);
}

public class CreateAttributeDefinitionRequestValidator : AbstractValidator<CreateAttributeDefinitionCommand>
{
    public CreateAttributeDefinitionRequestValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .WithMessage("Name is required.")
            .MaximumLength(100)
            .WithMessage("Name must not exceed 100 characters.");

        RuleFor(x => x.Unit)
            .NotEmpty()
            .WithMessage("Unit is required.")
            .MaximumLength(50)
            .WithMessage("Unit must not exceed 50 characters.");

        RuleFor(x => x.DataType)
            .NotEmpty()
            .WithMessage("Data type is required.")
            .Must(value => Enum.TryParse<AttributeDefinitionDataType>(value, ignoreCase: true, out _))
            .WithMessage("Data type must be a valid value(String, Number, Boolean, DateTime).");
    }
}