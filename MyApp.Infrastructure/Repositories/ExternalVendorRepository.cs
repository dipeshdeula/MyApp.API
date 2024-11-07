using MyApp.Core.Interfaces;
using MyApp.Core.Models;
using MyApp.Infrastructure.Services;

namespace MyApp.Infrastructure.Repositories
{
    public class ExternalVendorRepository :IExternalVendorRepository
    {
        private readonly ICoindeskHttpClientService _coindeskHttpClientServices;
        private readonly IJokeHttpClientService _jokeHttpClientServices;

        public ExternalVendorRepository(ICoindeskHttpClientService coindeskHttpClientService, IJokeHttpClientService jokeHttpClientServices)
        {
            _coindeskHttpClientServices = coindeskHttpClientService;
            _jokeHttpClientServices = jokeHttpClientServices;
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

        public async Task<JokeModel> GetJoke()
        {
            return await _jokeHttpClientServices.GetData();
        }

    }
}
