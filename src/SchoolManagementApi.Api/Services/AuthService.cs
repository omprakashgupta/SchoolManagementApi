using Microsoft.IdentityModel.Tokens;
using SchoolManagementApi.Api.DTOs.Auth;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SchoolManagementApi.Api.Services;

public interface IAuthService
{
    Task<LoginResponseDto?> AuthenticateAsync(LoginRequestDto dto);
}

public sealed class AuthService : IAuthService
{
    private readonly IConfiguration _configuration;

    public AuthService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public Task<LoginResponseDto?> AuthenticateAsync(LoginRequestDto dto)
    {
        var defaultUser = _configuration.GetSection("DefaultUser");
        var userId = defaultUser["UserId"];
        var password = defaultUser["Password"];
        var role = defaultUser["Role"] ?? "Admin";

        if (string.IsNullOrWhiteSpace(userId) || string.IsNullOrWhiteSpace(password))
        {
            return Task.FromResult<LoginResponseDto?>(null);
        }

        if (!string.Equals(dto.UserId, userId, StringComparison.OrdinalIgnoreCase) || dto.Password != password)
        {
            return Task.FromResult<LoginResponseDto?>(null);
        }

        var (token, expiresAt) = GenerateToken(userId, role);
        var response = new LoginResponseDto
        {
            UserId = userId,
            Role = role,
            Token = token,
            ExpiresAt = expiresAt
        };

        return Task.FromResult<LoginResponseDto?>(response);
    }

    private (string Token, DateTime ExpiresAt) GenerateToken(string userId, string role)
    {
        var jwtSection = _configuration.GetSection("Jwt");
        var issuer = jwtSection["Issuer"];
        var audience = jwtSection["Audience"];
        var key = jwtSection["Key"] ?? "replace-with-secure-key";
        var expiresMinutes = jwtSection.GetValue("ExpiresMinutes", 60);

        var claims = new List<Claim>
        {
            new(JwtRegisteredClaimNames.Sub, userId),
            new(JwtRegisteredClaimNames.UniqueName, userId),
            new(ClaimTypes.Role, role)
        };

        var credentials = new SigningCredentials(
            new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key)),
            SecurityAlgorithms.HmacSha256);

        var expires = DateTime.UtcNow.AddMinutes(expiresMinutes);
        var token = new JwtSecurityToken(
            issuer: issuer,
            audience: audience,
            claims: claims,
            expires: expires,
            signingCredentials: credentials);

        return (new JwtSecurityTokenHandler().WriteToken(token), expires);
    }
}
