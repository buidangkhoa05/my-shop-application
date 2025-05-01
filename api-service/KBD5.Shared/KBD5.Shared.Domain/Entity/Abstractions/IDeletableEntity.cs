namespace KBD5.Shared.Persistence.Entity.Abstractions;

public interface IDeletableEntity
{
    bool IsDeleted { get; set; }
    DateTimeOffset? DeletedOn { get; set; }
    string? DeletedBy { get; set; }
}
