using System.ComponentModel.DataAnnotations;

namespace Application.DTOs.Auth;

public class SetNewPasswordDto
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public string Code { get; set; }

    [Required]
    public string NewPassword { get; set; }

}
