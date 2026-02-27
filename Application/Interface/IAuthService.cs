
using Application.DTOs;

namespace Application.Interface
{
    public interface IAuthService
    {
        Task<(bool success, string? errorMessage)> LoginAsync(UserLoginRequest request);
    }
}
