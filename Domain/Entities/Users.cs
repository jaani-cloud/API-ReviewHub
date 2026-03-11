using Domain.Enums;
using System.Data;

namespace Domain.Entities;

public class Users
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Password { get; set; }
    public Role Role { get; set; } = Role.User;
    public bool EmailVerified { get; set; } = false;
    public string? ProfilePhoto { get; set; }
    public DateTime? Dob { get; set; }
    public string? Instagram { get; set; }
    public string? Youtube { get; set; }
    public bool IsDeleted { get; set; } = false;
    public bool IsActive { get; set; } = true;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public List<Reviews> Reviews { get; set; }
}
