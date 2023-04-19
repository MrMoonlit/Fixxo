using FixxoApi.Models.DTOs;
using FixxoApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;

namespace FixxoApi.Controllers;


[Route("api/[controller]")]
[ApiController]
public class AuthenticationController : ControllerBase
{
    #region Constructors & fields
    private readonly AuthService _authService;

    public AuthenticationController(AuthService authService)
    {
        _authService = authService;
    }

    #endregion

    #region SignUp
    [Route("SignUp")]
    [HttpPost]
    public async Task<IActionResult> SignUp(SignUpModelDTO model)
    {
        if (ModelState.IsValid)
            if (await _authService.RegisterAsync(model))
                return Created("", null);

        return BadRequest();
    }

    #endregion

    #region LogIn

    [Route("Login")]
    [HttpPost]
    public async Task<IActionResult> Login(LogInModelDTO model)
    {
        if (ModelState.IsValid)
        {
            var token = await _authService.LoginAsync(model);
            if(!string.IsNullOrEmpty(token))
                return Ok(token);
        }
        return BadRequest("Incorrect email or password");
    }






    #endregion
}
