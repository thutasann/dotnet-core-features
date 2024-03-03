using Mango.Services.AuthAPI.Dto;

namespace Mango.Services.AuthAPI.Service.IService
{
    public interface IAuthService
    {
        Task<string?> Register(RegisterationRequestDto registerationRequestDto);
        Task<LoginResponseDto> Login(LoginRequestDto loginRequestDto);
    }
}