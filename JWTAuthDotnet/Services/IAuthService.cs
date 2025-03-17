using JWTAuthDotnet.Entities;
using JWTAuthDotnet.Models;

namespace JWTAuthDotnet.Services
{
    public interface IAuthService
    {
        Task<User?> RegisterAsync(UserDto request);

        Task<string> LoginAsync(UserDto request);   
    }
}
