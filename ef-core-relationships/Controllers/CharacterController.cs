using ef_core_relationships.Dto;
using ef_core_relationships.Interfaces;
using ef_core_relationships.Mapper;
using Microsoft.AspNetCore.Mvc;

namespace ef_core_relationships.Controllers
{
    [ApiController]
    [Route("api/character")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterRepo _characterRepo;

        public CharacterController(ICharacterRepo characterRepo)
        {
            _characterRepo = characterRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetCharacters()
        {
            var characters = await _characterRepo.GetAllCharactersAsync();
            return Ok(characters);
        }

        [HttpGet("{userId:int}")]
        public async Task<IActionResult> GetCharactersByUserId([FromRoute] int userId)
        {
            var characters = await _characterRepo.GetCharactersByUserIdAsync(userId);
            return Ok(characters);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCharacter([FromForm] CharacterCreateDto characterCreateDto)
        {
            var characterModel = characterCreateDto.ToCharacterFromCreateDto();
            await _characterRepo.CreateCharacterAsync(characterModel);
            return Ok(characterCreateDto);
        }
    }
}