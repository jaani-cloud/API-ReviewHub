using System.ComponentModel.DataAnnotations;

namespace Application.DTOs.Auth;

public class ResendVerificationCodeDto
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
}
