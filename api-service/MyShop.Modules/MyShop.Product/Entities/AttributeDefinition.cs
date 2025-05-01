using KBD5.Shared.Persistence.Entity;

namespace MyShop.Product.Entities;

public class AttributeDefinition : BaseEntity
{
    public string Name { get; set; } = null!;  // e.g. "Weight"
    public string? Unit { get; set; }          // e.g. "kg", "cm"
    public string DataType { get; set; } = "string";
}

public enum AttributeDefinitionDataType
{
    String,
    Number,
    Boolean,
    DateTime
}
