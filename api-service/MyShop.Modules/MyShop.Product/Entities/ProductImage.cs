using KBD5.Shared.Persistence.Entities;

namespace MyShop.Product.Entities;

public class ProductImage : Entity
{
    public required string ImageUrl { get; set; }
    public required string ProductId { get; set; }
    public int SortOrder { get; set; } = 0;
    public bool IsMain { get; set; } = false;
}
