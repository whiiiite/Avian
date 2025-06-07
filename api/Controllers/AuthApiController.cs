using Microsoft.AspNetCore.Mvc;

namespace AvianApi.Controllers
{
    [ApiController]
    public class AuthApiController : ControllerBase
    {
        [HttpGet("auth")]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
