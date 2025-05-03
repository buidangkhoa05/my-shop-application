using KBD5.Shared.Persistence.Entity;

namespace MyShop.Product.Entities;

public class AttributeDefinition : BaseEntity
{
    public string Name { get; set; } = null!;
    public string? Unit { get; set; }
    public AttributeDefinitionDataType DataType { get; set; } = AttributeDefinitionDataType.String;
}

public enum AttributeDefinitionDataType
{
    String,
    Number,
    Boolean,
    DateTime
}