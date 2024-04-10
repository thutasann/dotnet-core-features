using AutoMapper;
using CommandsService.Dto;
using CommandsService.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CommandsService.Controllers
{
    [ApiController]
    [Route("api/c/platforms")]
    public class PlatformsController : ControllerBase
    {
        private static int inboundCount = 0;
        private readonly ICommandRepo _commandRepo;
        private readonly IMapper _mapper;
        private readonly ILogger<PlatformsController> _logger;

        public PlatformsController(ICommandRepo commandRepo, IMapper mapper, ILogger<PlatformsController> logger)
        {
            _commandRepo = commandRepo;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PlatformReadDto>> GetPlatforms()
        {
            _logger.LogInformation("--> Getting Platforms from CommandsService");

            var platforms = _commandRepo.GetAllPlatforms();
            return Ok(_mapper.Map<IEnumerable<PlatformReadDto>>(platforms));
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