using Play.Catalog.Service.Dtos;

namespace Play.Inventory.Service.Clients
{
    /// <summary>
    /// Catalog Http Client to retrive items from <b>Catalog Service</b>
    /// </summary>
    public class CatalogClient
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<CatalogClient> _logger;

        public CatalogClient(HttpClient httpClient, ILogger<CatalogClient> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        /// <summary>
        /// Get CatalogItems from Catalog Service
        /// </summary>
        /// <returns></returns>
        public async Task<IReadOnlyCollection<CatalogItemDto>> GetCatalogItemsAsync()
        {
            var items = await _httpClient.GetFromJsonAsync<IReadOnlyCollection<CatalogItemDto>>("/items");
            return items!;
        }
    }
}