namespace MyShop.Product.Entities;

public class ProductAttribute
{
    public required string AttributeDefinitionId { get; set; } = string.Empty;
    public required string Value { get; set; }
    public required string ProductId { get; set; } = string.Empty;


    public AttributeDefinition AttributeDefinition { get; set; } = null!;
    public Product? Product { get; set; }

}
