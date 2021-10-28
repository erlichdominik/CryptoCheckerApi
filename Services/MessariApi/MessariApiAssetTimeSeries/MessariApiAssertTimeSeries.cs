using System.Threading.Tasks;
using crypto_checker_api.Models.MessariApiModels.MessariAssetTimeSeries;

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
