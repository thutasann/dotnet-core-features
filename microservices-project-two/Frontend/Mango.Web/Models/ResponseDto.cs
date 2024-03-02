namespace Mango.Web.Models
{
    /// <summary>
    /// Response Format DTO
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ResponseDto
    {
        public object? Data { get; set; }
        public bool IsSuccess { get; set; } = true;
        public string? Message { get; set; } = "";
    }
}