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
            return Ok("this is a My Secured data");
        }
    }
}
