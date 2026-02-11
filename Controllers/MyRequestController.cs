using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NET_Core_Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyRequestController : ControllerBase
    {
        [Authorize]
        [HttpGet("GetMySecureData")]
        public IActionResult GetMySecureData()
        {

            // If token is missing or invalid, ASP.NET Core automatically sends 401
            if (!User.Identity?.IsAuthenticated ?? false)
            {
                return Unauthorized(new
                {
                    error = "Invalid or missing JWT token",
                    code = 401
                });
            }

            return Ok(new
            {
                message = "This is secured data",
                status = 200
            });

        }
    }
}
