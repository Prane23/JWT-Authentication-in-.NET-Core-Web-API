using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NET_Core_Web_API.Model;
using NET_Core_Web_API.Service;

namespace NET_Core_Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly JwtService jwtService;

        public AuthController(IConfiguration configuration)
        {
            _configuration=configuration;
            jwtService =  new JwtService(configuration);
        }

        [HttpPost("Login")]
        public IActionResult Login([FromBody] LoginInfo loginInfo)
        {
            if (loginInfo.Username == "Admin" && loginInfo.Password == "Password")
            {
                var token = jwtService.GenerateToken(loginInfo.Username);
                return Ok(new { Token = token });
            }
            return Unauthorized();
        }
       
    }
}
