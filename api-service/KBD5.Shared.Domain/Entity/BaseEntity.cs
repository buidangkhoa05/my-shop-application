using KBD5.Shared.Persistence.Entity.Abstractions;

namespace KBD5.Shared.Persistence.Entity;

public class BaseEntity : IIdentifiable, IDeletableEntity, IModifiableEntity
{
    public string Id { get; set; } = Guid.CreateVersion7().ToString("N");
    public bool IsDeleted { get; set; } = false;
    public DateTimeOffset? DeletedOn { get; set; }
    public string? DeletedBy { get; set; }
    public DateTimeOffset? UpdatedOn { get; set; }
    public string? UpdatedBy { get; set; }
}
