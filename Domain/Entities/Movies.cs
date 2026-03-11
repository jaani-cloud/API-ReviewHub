using Domain.Enums;

namespace Domain.Entities;

public class Movies
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Poster { get; set; }
    public string Description { get; set; }
    public int ReleaseYear { get; set; }
    public MovieType Type { get; set; }
    public string Category { get; set; }
    public string Genre { get; set; }
    public bool IsDeleted { get; set; } = false;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public List<Reviews> Reviews { get; set; }
}
