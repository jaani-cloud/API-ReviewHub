using System.ComponentModel.DataAnnotations;

namespace Application.DTOs.User;

public class ChangePasswordDto
{
    [Required]
    public string OldPassword { get; set; }

    [Required]
    public string NewPassword { get; set; }

    [Required]
    public string ConfirmPassword { get; set; }
}
