using System.Diagnostics;
using ef_core_relationships.Data;
using ef_core_relationships.Dto;
using ef_core_relationships.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ef_core_relationships.Controllers
{
    /// <summary>
    /// The Last of Us Game Controller
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TlouController : ControllerBase
    {
        private readonly DataContext _context;

        public TlouController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("characters")]
        public async Task<ActionResult<List<Character>>> GetAllCharacters()
        {
            var stopWatch = Stopwatch.StartNew();
            var result = await _context.Characters
                            .Include(c => c.Backpack)
                            .Include(c => c.Weapons)
                            .Include(c => c.Factions)
                            .ToListAsync();

            stopWatch.Stop();
            Console.WriteLine($"--> All Characters API call took {stopWatch.ElapsedMilliseconds} milliseconds.");
            return Ok(result);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Character>> GetCharacter([FromRoute] int id)
        {
            var stopwatch = Stopwatch.StartNew();
            var character = await _context.Characters
                                    .Include(c => c.Backpack)
                                    .Include(c => c.Weapons)
                                    .Include(c => c.Factions)
                                    .FirstOrDefaultAsync(c => c.Id == id);
            if (character == null)
                return NotFound("Character not Found");

            stopwatch.Stop();
            Console.WriteLine($"--> Character Detail API call took {stopwatch.ElapsedMilliseconds} milliseconds.");
            return Ok(character);
        }

        [HttpGet("{id:int}/weapon-count")]
        public async Task<IActionResult> GetCharacterWeaponCount(int id)
        {
            var stopWatch = Stopwatch.StartNew();
            var character = await _context.Characters
                                    .Include(c => c.Weapons)
                                    .FirstOrDefaultAsync(c => c.Id == id);
            if (character == null)
                return NotFound("Character not found");

            int weaponCount = character.Weapons?.Count ?? 0;
            var response = new
            {
                character.Name,
                count = weaponCount
            };
            stopWatch.Stop();
            Console.WriteLine($"--> Weapon Count API call took {stopWatch.ElapsedMilliseconds} milliseconds.");
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<List<Character>>> CreateChracter(CharacterCreateDto request)
        {
            var startTime = DateTime.Now;

            var newCharacter = new Character
            {
                Name = request.Name,
            };

            var backpack = new Backpack
            {
                Description = request.Backpack.Description,
                Character = newCharacter
            };

            var weapons = request.Weapons
                            .Select(w => new Weapon { Name = w.Name, Character = newCharacter })
                            .ToList();

            var factions = request.Factions
                             .Select(f => new Faction { Name = f.Name, Characters = new List<Character> { newCharacter } })
                             .ToList();

            newCharacter.Backpack = backpack;
            newCharacter.Weapons = weapons;
            newCharacter.Factions = factions;

            await _context.Characters.AddAsync(newCharacter);
            await _context.SaveChangesAsync();

            var response = await _context.Characters
                                .Include(c => c.Backpack)
                                .Include(c => c.Weapons)
                                .ToListAsync();

            var endTime = DateTime.Now;
            var elapsedTime = endTime - startTime;
            Console.WriteLine($"--> Character Create API call took {elapsedTime.TotalMilliseconds} milliseconds.");
            return Ok(response);
        }

    }
}