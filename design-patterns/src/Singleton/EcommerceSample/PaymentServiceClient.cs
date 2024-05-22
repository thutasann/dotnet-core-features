namespace design_patterns.src.Singleton.EcommerceSample
{
    /// <summary>
    /// Using Configuration Settings in Payment Service Client
    /// </summary>
    public class PaymentServiceClient
    {
        private readonly HttpClient _httpClient;

        public PaymentServiceClient()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://api.paymentprovider.com/")

            };
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {ConfigurationSettings.Instance.ApiKey}");
        }

        public async void Proceed()
        {
            Console.WriteLine($"Proceed with this API Key {ConfigurationSettings.Instance.ApiKey}");
            await Task.CompletedTask;
        }
    }
}