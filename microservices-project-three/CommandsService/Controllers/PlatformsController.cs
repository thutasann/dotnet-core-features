using Microsoft.AspNetCore.Mvc;

namespace CommandsService.Controllers
{
    [ApiController]
    [Route("api/c/platforms")]
    public class PlatformsController : ControllerBase
    {
        private static int inboundCount = 0;

        public PlatformsController()
        {

        }

        [HttpPost]
        public IActionResult TestInboundConnection()
        {
            inboundCount++;
            Console.WriteLine($"==> Inbound POST # Command Service , count => {inboundCount}");
            return Ok("Inbound test of from Platforms Controller");
        }
    }
}