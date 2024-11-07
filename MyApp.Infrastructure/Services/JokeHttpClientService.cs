using MyApp.Core.Models;
using System.Net.Http.Json;

namespace MyApp.Infrastructure.Services
{
    public class JokeHttpClientService : IJokeHttpClientService
    {
        private readonly HttpClient _httpClient;

        public JokeHttpClientService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<JokeModel> GetData()
        {
            return await _httpClient.GetFromJsonAsync<JokeModel>("random_joke");
        }

    }
}
