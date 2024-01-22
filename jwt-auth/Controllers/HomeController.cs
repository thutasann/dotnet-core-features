using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using jwt_auth.Middleware;
using System.Security.Claims;

namespace jwt_auth.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    [CustomResponseFormat]
    public class HomeController : ControllerBase
    {
        [HttpGet("/home")]
        [Authorize]
        public IActionResult Index()
        {
            string id = HttpContext.User.FindFirstValue("id")!;
            string email = HttpContext.User.FindFirstValue(ClaimTypes.Email)!;
            string username = HttpContext.User.FindFirstValue(ClaimTypes.Name)!;

            return Ok();
        }
    }
}