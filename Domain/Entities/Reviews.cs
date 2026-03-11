using Domain.Enums;

namespace Domain.Entities;

public class Reviews
{
    public int Id { get; set; }
    public int MovieId { get; set; }
    public int UserId { get; set; }
    public ReviewType Type { get; set; }
    public string? Comment { get; set; }
    public int Rating { get; set; }
    public bool IsDeleted { get; set; } = false;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public Movies Movies { get; set; }
    public Users Users { get; set; }
}
