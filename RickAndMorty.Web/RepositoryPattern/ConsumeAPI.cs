using RickAndMorty.Shared.Data;
using System.Text.Json;

namespace RickAndMorty.Web.Services
{
    public class ConsumeAPI : IConsumeAPI
    {

        private readonly HttpClient _httpClient;

        public ConsumeAPI(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<T> GetIndividualDataAsync<T>(string data)
        {
            var apiResponse = await GetResposeHttpAsync(data);
            var jsonSerializer = JsonSerializer.Deserialize<T>(apiResponse);
            return jsonSerializer!;
        }

        public async Task<List<T>> GetListByEntity<T>(string data)
        {
            var apiResponse = await GetResposeHttpAsync(data);
            var jsonSerializer = JsonSerializer.Deserialize<List<T>>(apiResponse);
            return jsonSerializer!;
        }

        public async Task<GeneralResponse<T>> GetListDataAsync<T>(string data)
        {
            var apiResponse = await GetResposeHttpAsync(data);
            var jsonSerializer = JsonSerializer.Deserialize<GeneralResponse<T>>(apiResponse);
            return jsonSerializer!;

        }



        public async Task<string> GetResposeHttpAsync(string data)
        {
            using var responseHttp = await _httpClient.GetAsync(data);
            var apiResponse = await responseHttp.Content.ReadAsStringAsync();
            return apiResponse;
        }

    }
}
