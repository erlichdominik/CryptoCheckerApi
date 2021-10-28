using System.Threading.Tasks;
using crypto_checker_api.Models.MessariApiModels;
using crypto_checker_api.Services.MessariApi.MessariApiAssetTimeSeries;

namespace crypto_checker_api.Services.MessariApi.MessariApiAssetTimeSeries
{
    public class MessariApiAssetTimeSeries : IMessariApiAssertTimeSeries
    {
        public Task<MessariAssetTimeSeries> GetMessariAssetTimeSeriesAsync(string slug)
        {
            throw new System.NotImplementedException();
        }
    }
}
