using Mango.Web.Utils;
using static Mango.Web.Utils.SD;

namespace Mango.Web.Models
{
    /// <summary>
    /// Request Form DTO
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class RequestDto
    {
        public APITypeEnum ApiType { get; set; } = APITypeEnum.GET;
        public required string Url { get; set; }
        public object? Data { get; set; }
        public string? Accesstoken { get; set; }
        public ContentType ContentType { get; set; } = ContentType.Json;
    }
}