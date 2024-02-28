namespace Mango.Web.Models
{
    /// <summary>
    /// Response Format DTO
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ResponseDto<T>
    {
        public T? Data { get; set; }
        public bool IsSuccess { get; set; } = true;
        public string? Message { get; set; } = "";
    }
}