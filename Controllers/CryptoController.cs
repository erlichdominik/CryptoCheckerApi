using System.Threading.Tasks;
using crypto_checker_api.Services.MessariApi.MessariApiAllAssets;
using Microsoft.AspNetCore.Mvc;

namespace crypto_checker_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CryptoController : ControllerBase
    {
        private readonly IMessariApiAllAssets _messariAllAssets;

        public CryptoController(IMessariApiAllAssets messariAllAssets)
        {
            _messariAllAssets = messariAllAssets;
        }
        [HttpGet("assets")]
        public async Task<IActionResult> GetMessariApiAllAssets()
        {
            var response = await _messariAllAssets.GetMessariApiAllAssetsAsync();

            //TODO(dominik) add HTTP status to validate data
            return response != null ? Ok(response) : NotFound();
        }

        [HttpGet("assets/market_data")]
        public async Task<IActionResult> GetMasseriApiAllAssetsWithMarketData()
        {
            var response = await _messariAllAssets.GetMessariAllAssetsWithMarketDataAsync();
            return response != null ? Ok(response) : NotFound();
        }

    }

}
