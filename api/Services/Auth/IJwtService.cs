using AvianApi.Models.Entities;

namespace AvianApi.Services.Auth
{
    public interface IJwtService
    {
        string GenerateToken(User user);
    }
}
