using KBD5.Shared.Persistence.Entity;

namespace MyShop.Product.Entities;

public class Category : BaseEntity
{
    public required string Name { get; set; }

    public string? ParentId { get; set; }


    public Category? Parent { get; set; }

    public ICollection<Category>? SubCategories { get; set; }
}
