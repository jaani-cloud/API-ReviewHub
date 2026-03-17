using System.ComponentModel.DataAnnotations;

namespace Application.DTOs.Auth;

public class VerifyEmailCodeDto
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public string Code { get; set; }
}
