using System.Threading.Tasks;

namespace crypto_checker_api.Services.MessariApi.MessariApiAllAssets
{
    public interface IMessariApiAllAssets
    {
        Task<crypto_checker_api.Models.MessariApiModels.MessariAllAssets.MessariAllAssets> GetMessariApiAllAssetsAsync();
        Task<crypto_checker_api.Models.MessariApiModels.MessariAllAssetsMarketData.MessariAllAssetsMarketData> GetMessariAllAssetsWithMarketDataAsync();
    }

}
