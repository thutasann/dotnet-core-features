using ef_core_relationships.Dto;
using ef_core_relationships.Models;

namespace ef_core_relationships.Mapper
{
    public static class UserMapper
    {
        public static User ToUserFromCreateDTO(this UserCreateDto userCreateDto)
        {
            return new User
            {
                UserName = userCreateDto.UserName,
            };
        }
    }
}