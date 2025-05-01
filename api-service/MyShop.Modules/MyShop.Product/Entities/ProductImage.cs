using KBD5.Shared.Persistence.Entity;

namespace MyShop.Product.Entities;

public class ProductImage : BaseEntity
{
    public required string ImageUrl { get; set; }
    public required string ProductId { get; set; }
    public int SortOrder { get; set; } = 0;
    public bool IsMain { get; set; } = false;
}
