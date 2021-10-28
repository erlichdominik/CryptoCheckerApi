using System.Threading.Tasks;
using crypto_checker_api.Models.MessariApiModels;
namespace crypto_checker_api.Services.MessariApi.MessariApiAssetTimeSeries
{
    public interface IMessariApiAssertTimeSeries
    {
        Task<MessariAssetTimeSeries> GetMessariAssetTimeSeriesAsync(string slug);
    }
}
