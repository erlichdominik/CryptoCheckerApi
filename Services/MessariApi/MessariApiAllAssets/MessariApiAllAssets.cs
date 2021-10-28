using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using crypto_checker_api.Models.MessariApiModels.MessariAllAssets;

namespace crypto_checker_api.Services.MessariApi.MessariApiAllAssets
{
    public class MessariApiAllAssets : IMessariApiAllAssets
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly string _messariApiAllAssetsCallUri = "https://data.messari.io/api/v2/assets";

        public MessariApiAllAssets(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<MessariAllAssets> GetMessariApiAllAssetsAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetFromJsonAsync<MessariAllAssets>(_messariApiAllAssetsCallUri);

            return response;
        }
    }
}

