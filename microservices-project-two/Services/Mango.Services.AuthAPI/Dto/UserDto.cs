namespace Mango.Services.AuthAPI.Dto
{
    public class UserDto
    {
        public required string ID { get; set; }
        public required string Email { get; set; }
        public required string Name { get; set; }
        public required string PhoneNumber { get; set; }
    }
}