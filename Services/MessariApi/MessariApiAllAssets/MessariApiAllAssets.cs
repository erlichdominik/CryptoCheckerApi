using System.Net.Http;
using System.Threading.Tasks;
using crypto_checker_api.Models.MessariApiModels.MessariAllAssets;

namespace crypto_checker_api.Services.MessariApi.MessariApiAllAssets
{
    public class MessariApiAllAssets : IMessariApiAllAssets
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public MessariApiAllAssets(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public Task<MessariAllAssets> GetMessariApiAllAssetsAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}

