using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using crypto_checker_api.Models.MessariApiModels.MessariAllAssets;
using crypto_checker_api.Models.MessariApiModels.MessariAllAssetsMarketData;

namespace crypto_checker_api.Services.MessariApi.MessariApiAllAssets
{
    public class MessariApiAllAssets : IMessariApiAllAssets
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public MessariApiAllAssets(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<MessariAllAssetsMarketData> GetMessariAllAssetsWithMarketDataAsync()
        {
            string callUri = "https://data.messari.io/api/v2/assets?fields=id,slug,symbol,metrics/market_data";
            return await GetDataFromJsonAsync<MessariAllAssetsMarketData>(callUri);
        }

        public async Task<MessariAllAssets> GetMessariApiAllAssetsAsync()
        {

            string callUri = "https://data.messari.io/api/v2/assets";

            return await GetDataFromJsonAsync<MessariAllAssets>(callUri);
        }


        private async Task<T> GetDataFromJsonAsync<T>(string callUri)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetFromJsonAsync<T>(callUri);

            return response;
        }
    }
}

