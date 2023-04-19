using FixxoApi.Helpers;
using FixxoApi.Models.DTOs;
using FixxoApi.Models.Entities;
using FixxoApi.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Security.Claims;

namespace FixxoApi.Services;

public class AuthService
{
    #region Private fields & constructors
    private readonly UserManager<IdentityUser> _userManager;
    private readonly UserProfileRepository _userProfileRepository;
    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly JwtToken _jwt;

    public AuthService(UserManager<IdentityUser> userManager, UserProfileRepository userProfileRepository, SignInManager<IdentityUser> signInManager, JwtToken jwt)
    {
        _userManager = userManager;
        _userProfileRepository = userProfileRepository;
        _signInManager = signInManager;
        _jwt = jwt;
    }

    #endregion

    #region Register
    public async Task<bool> RegisterAsync(SignUpModelDTO model)
    {
		try
		{
			var identityResult = await _userManager.CreateAsync(model, model.Password);
            if (identityResult.Succeeded)
            {
                var identityUser = await _userManager.FindByEmailAsync(model.Email);
                UserProfileEntity userProfileEntity = model;
                userProfileEntity.UserID = identityUser!.Id;
                await _userProfileRepository.AddAsync(userProfileEntity);
                return true;
            }
		}
		catch { }

        return false;
    }
    #endregion

    #region Login
    public async Task<string> LoginAsync(LogInModelDTO model)
    {
        var identityUser = await _userManager.FindByEmailAsync(model.Email);
        if (identityUser != null)
        {
            var signInResult = await _signInManager.CheckPasswordSignInAsync(identityUser, model.Password, false);
            if (signInResult.Succeeded)
            {
                var claimsIdentity = new ClaimsIdentity(new Claim[]
                {
                    new Claim("id", identityUser.Id.ToString()),
                    new Claim(ClaimTypes.Name, identityUser.Email!)
                });

                return _jwt.Generate(claimsIdentity, DateTime.Now.AddHours(1));
            }

        }

        return string.Empty;
    }

    #endregion
}
