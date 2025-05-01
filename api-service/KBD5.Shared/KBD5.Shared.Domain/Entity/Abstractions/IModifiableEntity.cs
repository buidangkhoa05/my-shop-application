namespace KBD5.Shared.Persistence.Entity.Abstractions;

public interface IModifiableEntity
{
    public DateTimeOffset? UpdatedOn { get; set; }
    public string? UpdatedBy { get; set; }
}
