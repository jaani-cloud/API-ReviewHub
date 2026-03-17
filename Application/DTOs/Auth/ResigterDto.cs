using System.ComponentModel.DataAnnotations;

namespace Application.DTOs.Auth;

public class ResigterDto
{
    [Required(ErrorMessage = "First name is required")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Last name is required")]
    public string LastName { get; set; }

    [EmailAddress(ErrorMessage = "Invalid email format")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Phone number is required")]
    [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Phone number must be exactly 10 digits")]
    public string PhoneNumber { get; set; }

    [Required(ErrorMessage = "Password is required")]
    public string Password { get; set; }
}
