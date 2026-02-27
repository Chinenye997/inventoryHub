
using Application.DTOs;
using Application.Interface;
using Microsoft.AspNetCore.Identity;

namespace Application.Services;

public class AuthService:IAuthService
{
    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly UserManager<IdentityUser> _userManager;

    public AuthService(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
    {
        _signInManager = signInManager;
        _userManager = userManager;
    }

    public async Task<(bool success, string? errorMessage)> LoginAsync(UserLoginRequest request)
    {
        var user = await _userManager.FindByEmailAsync(request.UsernameOrEmail)
                   ?? await _userManager.FindByNameAsync(request.UsernameOrEmail);

        if (user == null)
        {
            return (success: false, errorMessage: "Invalid login attempt.");
        }

        var result = await _signInManager.PasswordSignInAsync(
            user,
            request.Password,
            request.RememberMe,
            lockoutOnFailure: false);

        if (result.Succeeded)
        {
            return (success: true, errorMessage: null);
        }

        if (result.IsLockedOut)
        {
            return (success: false, errorMessage: "Account locked out.");
        }

        return (success: false, errorMessage: "Invalid login attempt.");
    }
}
