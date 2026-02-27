namespace Domain;

public class BaseEntity
{
    public BaseEntity()
    {
        //Id = Guid.NewGuid().ToString().Replace("-", "");
        Id = Guid.NewGuid().ToString("N");
        CreatedAt = DateTime.UtcNow;
        IsActive = true;
    }
    public string Id { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public bool IsActive { get; set; }

    // Optional: Use these in derived if needed
    public DateTime? UpdatedAt { get; set; }
    public string? CreatedBy { get; set; }
    public string? UpdatedBy { get; set; }
}
