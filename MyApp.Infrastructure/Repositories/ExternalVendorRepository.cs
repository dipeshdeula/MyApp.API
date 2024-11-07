using MyApp.Core.Interfaces;
using MyApp.Core.Models;
using MyApp.Infrastructure.Services;

namespace MyApp.Infrastructure.Repositories
{
    public class ExternalVendorRepository :IExternalVendorRepository
    {
        private readonly CoindeskHttpClientService _coindeskHttpClientServices;

        public ExternalVendorRepository(CoindeskHttpClientService coindeskHttpClientService)
        {
            _coindeskHttpClientServices = coindeskHttpClientService;
        }

  /*      public async Task<dynamic> GetBitCoinPrice()
        { 
            return await _coindeskHttpClientServices.GetData();
        }
*/
        public async Task<CoindeskData> GetData()
        {
            return await _coindeskHttpClientServices.GetData();
        }

    }
}
