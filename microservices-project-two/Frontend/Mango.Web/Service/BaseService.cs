using System.Net;
using System.Text;
using Mango.Web.Models;
using Mango.Web.Service.IService;
using Mango.Web.Utils;
using Newtonsoft.Json;

namespace Mango.Web.Service
{
    /// <summary>
    /// API Base Service
    /// </summary>
    public class BaseService : IBaseService
    {

        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<BaseService> _logger;

        public BaseService(IHttpClientFactory httpClientFactory, ILogger<BaseService> logger)
        {
            _httpClientFactory = httpClientFactory;
            _logger = logger;
        }

        public async Task<ResponseDto> SendAsync(RequestDto<object> requestDto)
        {
            try
            {
                HttpClient client = _httpClientFactory.CreateClient("MangoAPI");
                HttpRequestMessage message = new();
                message.Headers.Add("Accept", "application/json");
                message.RequestUri = new Uri(requestDto.Url);
                if (requestDto.Data != null)
                {
                    message.Content = new StringContent(JsonConvert.SerializeObject(requestDto.Data), Encoding.UTF8, "application/json");
                }
                HttpResponseMessage? apiResponse = null;

                message.Method = requestDto.ApiType switch
                {
                    APITypeEnum.POST => HttpMethod.Post,
                    APITypeEnum.DELETE => HttpMethod.Delete,
                    APITypeEnum.PUT => HttpMethod.Put,
                    _ => HttpMethod.Get,
                };

                apiResponse = await client.SendAsync(message);

                switch (apiResponse.StatusCode)
                {
                    case HttpStatusCode.NotFound:
                        return new() { IsSuccess = false, Message = "Not Found " };
                    case HttpStatusCode.Forbidden:
                        return new() { IsSuccess = false, Message = "Access Denied" };
                    case HttpStatusCode.Unauthorized:
                        return new() { IsSuccess = false, Message = "Unauthorized" };
                    case HttpStatusCode.InternalServerError:
                        return new() { IsSuccess = false, Message = "Internal Server Error" };
                    default:
                        var apiContent = await apiResponse.Content.ReadAsStringAsync();
                        var apiResponseDto = JsonConvert.DeserializeObject<ResponseDto>(apiContent);
                        return apiResponseDto!;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Something went wrong in Base Service", ex.Message);
                var dto = new ResponseDto
                {
                    Message = ex.Message.ToString(),
                    IsSuccess = false
                };
                return dto;
            }
        }
    }
}