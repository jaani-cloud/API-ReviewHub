namespace Application.DTOs.User;

public class UserProfileDto
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string? ProfilePhoto { get; set; }
    public DateTime? Dob { get; set; }
    public string? Instagram { get; set; }
    public string? Youtube { get; set; }
    public string Role { get; set; }
}
