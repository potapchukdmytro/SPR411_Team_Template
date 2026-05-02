using Microsoft.AspNetCore.Mvc;

namespace SPR411_TeamProject_Template.Controllers
{
    [ApiController]
    [Route("/api/auth")]
    public class AuthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello World");
        }

        [HttpPost]
        public IActionResult Login()
        {
            return Ok("Login");
        }
    }
}
