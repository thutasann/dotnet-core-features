using Mango.Web.Models;

namespace Mango.Web.Service.IService
{
    public interface IBaseService
    {
        Task<ResponseDto<object>?> SendAsync(RequestDto<object> requestDto);
    }
}