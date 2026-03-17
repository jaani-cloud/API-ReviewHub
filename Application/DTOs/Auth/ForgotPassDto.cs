using System.ComponentModel.DataAnnotations;

namespace Application.DTOs.Auth;

public class ForgotPassDto
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
}
