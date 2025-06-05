using Microsoft.AspNetCore.Mvc;

namespace AvianApi.Controllers
{
    [ApiController]
    public class AuthApiController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
