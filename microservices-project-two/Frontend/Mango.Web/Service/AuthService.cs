using Mango.Web.Models;
using Mango.Web.Service.IService;
using Mango.Web.Utils;

namespace Mango.Web.Service
{
    public class AuthService : IAuthService
    {

        private readonly IBaseService _baseService;

        public AuthService(IBaseService baseService)
        {
            _baseService = baseService;
        }

        public async Task<ResponseDto> AssignRoleAsync(RegisterRequestDto assignRoleRequestDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = APITypeEnum.POST,
                Data = assignRoleRequestDto,
                Url = SD.AuthAPIBase + "/api/auth/AssignRole"
            });
        }

        public async Task<ResponseDto> LoginAsync(LoginRequestDto loginRequestDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = APITypeEnum.POST,
                Data = loginRequestDto,
                Url = SD.AuthAPIBase + "/api/auth/login"
            });
        }

        public async Task<ResponseDto> RegisterAsync(RegisterRequestDto registerRequestDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = APITypeEnum.POST,
                Data = registerRequestDto,
                Url = SD.AuthAPIBase + "/api/auth/register"
            });
        }
    }
}