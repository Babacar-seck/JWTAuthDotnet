using JWTAuthDotnet.Entities;
using JWTAuthDotnet.Models;
using JWTAuthDotnet.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace JWTAuthDotnet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(IAuthService authService) : ControllerBase
    {


        [HttpPost("register")]
        public async Task< ActionResult<User>> Register(UserDto request)
        {
           
            var user = await authService.RegisterAsync(request);

            if (user is null)
            {
                return BadRequest("UserName already exists.");
            }

            return Ok(user);
        }

        [HttpPost("login")]

        public async Task<ActionResult<string>> Login(UserDto request)
        {
            string token = await authService.LoginAsync(request);

            if (token is null )
            {
                return BadRequest("Invalid UserName or Password");
            }

            return token;
        }

        [Authorize]
        [HttpGet("Authenticated")]
        public ActionResult<string> AuthEndpointOnly()
        {
            return  Ok("You are Authenticated");
        }

       
    }
}
