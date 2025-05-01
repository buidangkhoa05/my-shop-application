using KBD5.Shared.Persistence.Entity;

namespace MyShop.Product.Entities;

public class Product : BaseEntity
{
    public required string Sku { get; set; }

    public required string FullName { get; set; }

    public required string ShortName { get; set; }

    public string? Description { get; set; }

    public bool IsActive { get; set; } = true;
}