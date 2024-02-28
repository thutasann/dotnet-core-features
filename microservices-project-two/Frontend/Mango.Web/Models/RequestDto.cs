using Mango.Web.Utils;

namespace Mango.Web.Models
{
    /// <summary>
    /// Request Form DTO
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class RequestDto<T>
    {
        public APITypeEnum ApiType { get; set; } = APITypeEnum.GET;
        public required string Url { get; set; }
        public T? Data { get; set; }
        public required string Accesstoken { get; set; }
    }
}