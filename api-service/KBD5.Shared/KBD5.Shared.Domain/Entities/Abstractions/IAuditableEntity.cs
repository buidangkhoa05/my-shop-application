namespace KBD5.Shared.Persistence.Entities.Abstractions;

public interface IAuditableEntity
{
    bool IsDeleted { get; set; }
    DateTimeOffset CreatedOn { get; set; }
    string? CreatedBy { get; set; }
    DateTimeOffset? UpdatedOn { get; set; }
    string? UpdatedBy { get; set; }
    DateTimeOffset? DeletedOn { get; set; }
    string? DeletedBy { get; set; }
}
