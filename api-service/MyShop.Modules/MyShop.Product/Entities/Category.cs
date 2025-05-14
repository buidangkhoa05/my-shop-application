using KBD5.Shared.Persistence.Entities;

namespace MyShop.Product.Entities;

public class Category : Entity
{
    public required string Name { get; set; }

    public string? ParentId { get; set; }

    public Category? Parent { get; set; }

    public ICollection<Category>? SubCategories { get; set; }
}