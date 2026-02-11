using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using NET_Core_Web_API.Config;
using NET_Core_Web_API.Model;
using NET_Core_Web_API.Service;

namespace NET_Core_Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly JwtService _JwtService;

        public AuthController(JwtService JwtService)
        {
            _JwtService = JwtService;
        }

        [HttpPost("Login")]
        public IActionResult Login([FromBody] LoginInfo loginInfo)
        {
            if (loginInfo.Username == "Admin" && loginInfo.Password == "Password")
            {
                var token = _JwtService.GenerateToken(loginInfo.Username);
                return Ok(new { Token = token });
            }

            return Unauthorized(new
            {
                error = "Invalid username or password",
                code = 401
            });

        }

    }
}
