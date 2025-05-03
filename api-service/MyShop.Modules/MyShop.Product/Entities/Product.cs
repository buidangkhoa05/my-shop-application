using KBD5.Shared.Persistence.Entities;

namespace MyShop.Product.Entities;

public class Product : Entity
{
    public required string Sku { get; set; }

    public required string FullName { get; set; }

    public required string ShortName { get; set; }

    public string? Description { get; set; }

    public bool IsActive { get; set; } = true;
}