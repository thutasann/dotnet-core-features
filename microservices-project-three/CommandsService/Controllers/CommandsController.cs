using AutoMapper;
using CommandsService.Dto;
using CommandsService.Models;
using CommandsService.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CommandsService.Controllers
{
    [ApiController]
    [Route("api/c/platforms/{platformId}/commands")]
    public class CommandsController : ControllerBase
    {
        private readonly ILogger<CommandsController> _logger;
        private readonly ICommandRepo _commandRepo;
        private readonly IMapper _mapper;

        public CommandsController(ILogger<CommandsController> logger, ICommandRepo commandRepo, IMapper mapper)
        {
            _logger = logger;
            _commandRepo = commandRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CommandReadDto>> GetCommandsForPlatform(int platformId)
        {
            _logger.LogInformation("==> Hit GetCommandsForPlatform : " + platformId);
            if (!_commandRepo.PlatformExists(platformId))
            {
                return NotFound();
            }

            var commands = _commandRepo.GetCommandsForPlatform(platformId);
            return Ok(_mapper.Map<IEnumerable<CommandReadDto>>(commands));
        }

        [HttpGet("{commandId}", Name = "GetCommandForPlatform")]
        public ActionResult<CommandReadDto> GetCommandForPlatform(int platformId, int commandId)
        {
            _logger.LogInformation($"==> Hitting GetCommandForPlatform : platformId => {platformId}, commandId => {commandId}");

            if (_commandRepo.PlatformExists(platformId))
            {
                return NotFound();
            }

            var command = _commandRepo.GetCommand(platformId, commandId);

            if (command == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<CommandReadDto>(command));
        }

        [HttpPost]
        public ActionResult<CommandReadDto> CreateCommandForPlatform(int platformId, [FromForm] CommandCreateDto commandDto)
        {
            _logger.LogInformation($"==> CreateCommandForPlatform : {platformId}");

            if (!_commandRepo.PlatformExists(platformId))
            {
                return NotFound();
            }

            var command = _mapper.Map<Command>(commandDto);
            _commandRepo.CreateCommand(platformId, command);
            _commandRepo.SaveChanges();

            var commandReadDto = _mapper.Map<CommandReadDto>(command);
            return CreatedAtRoute(nameof(GetCommandForPlatform), new
            {
                platformId = platformId,
                commandId = commandReadDto.Id,
            }, commandReadDto);
        }
    }
}