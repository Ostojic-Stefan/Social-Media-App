namespace Data.Models;

public abstract class BaseEntity
{
    public Guid Id { get; set; }
    DateTime CreatedAt { get; set; }
    DateTime UpdatedAt { get; set; }
}
