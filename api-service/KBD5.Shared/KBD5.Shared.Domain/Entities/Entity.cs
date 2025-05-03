using KBD5.Shared.Persistence.Entities.Abstractions;
using System.ComponentModel.DataAnnotations.Schema;

namespace KBD5.Shared.Persistence.Entities;

public abstract class Entity : IIdentifiableEntity, IAuditableEntity
{
    [Column(Order = 1)]
    public string Id { get; set; } = Guid.CreateVersion7().ToString("N");
    [Column(Order = 99)]
    public DateTimeOffset CreatedOn { get; set; }
    public string? CreatedBy { get; set; }
    [Column(Order = 99)]
    public DateTimeOffset? UpdatedOn { get; set; }
    [Column(Order = 99)]
    public string? UpdatedBy { get; set; }
    [Column(Order = 99)]
    public DateTimeOffset? DeletedOn { get; set; }
    [Column(Order = 99)]
    public string? DeletedBy { get; set; }
    [Column(Order = 99)]
    public bool IsDeleted { get; set; } = false;
}