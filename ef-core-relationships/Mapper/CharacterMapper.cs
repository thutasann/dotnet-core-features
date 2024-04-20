using ef_core_relationships.Dto;
using ef_core_relationships.Models;

namespace ef_core_relationships.Mapper
{
    public static class CharacterMapper
    {
        public static Character ToCharacterFromCreateDto(this CharacterCreateDto characterCreateDto)
        {
            return new Character
            {
                Name = characterCreateDto.Name,
                RpgClass = characterCreateDto.RpgClass,
                UserId = characterCreateDto.UserId,
            };
        }
    }
}