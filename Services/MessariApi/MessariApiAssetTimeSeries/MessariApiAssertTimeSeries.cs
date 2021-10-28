using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using crypto_checker_api.Models.MessariApiModels.MessariAssetTimeSeries;

namespace crypto_checker_api.Services.MessariApi.MessariApiAssetTimeSeries
{
    public class MessariApiAssetTimeSeries : IMessariApiAssertTimeSeries
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public MessariApiAssetTimeSeries(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<MessariAssetTimeSeries> GetMessariAssetTimeSeriesAsync(string slug)
        {
            //TODO optional add another options to search time series
            var client = _httpClientFactory.CreateClient();
            string callUri = $"https://data.messari.io/api/v1/assets/{slug}/metrics/price/time-series?start=2020-01-01&end=2020-02-01&interval=1d";
            var response = await client.GetFromJsonAsync<MessariAssetTimeSeries>(callUri);
            return response;
        }
    }
}
