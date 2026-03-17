namespace Application.DTOs.Auth;

public class AuthResponseDto
{
    public int? UserId { get; set; }
    public bool Success { get; set; }
    public string? Token { get; set; }
    public string? Role { get; set; }
}
