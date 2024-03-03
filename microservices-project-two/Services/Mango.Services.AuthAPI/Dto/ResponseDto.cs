namespace Mango.Services.AuthAPI.Dto
{
    public class ResponseDto<T>
    {
        public T? Data { get; set; }
        public bool IsSuccess { get; set; } = true;
        public string? Message { get; set; } = "";
    }
}