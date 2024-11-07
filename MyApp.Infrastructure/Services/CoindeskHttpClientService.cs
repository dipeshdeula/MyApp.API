using MyApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Infrastructure.Services
{
    public class CoindeskHttpClientService
    {
        private readonly HttpClient _httpClient;

        public CoindeskHttpClientService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CoindeskData> GetData()
        { 
            return await _httpClient.GetFromJsonAsync<CoindeskData>("https://api.coindesk.com/v1/bpi/currentprice.json");
        }
    }
    
}
