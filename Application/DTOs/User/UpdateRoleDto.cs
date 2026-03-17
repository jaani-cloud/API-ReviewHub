using Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Application.DTOs.User;

public class UpdateRoleDto
{
    [Required]
    public Role Role { get; set; }
}
