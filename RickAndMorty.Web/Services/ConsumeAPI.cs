using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RickAndMorty.Web.Services
{
    public class ConsumeAPI : IConsumeAPI
    {

        private readonly HttpClient _httpClient;

        //public ConsumeAPI(HttpClient httpClient)
        //{
        //    _httpClient = httpClient;
        //}

        public async Task<T> GetIndividualDataAsync<T>(string data)
        {
            using (var httpClient = new HttpClient())
            {
                using (var responseHttp = await httpClient.GetAsync($"https://rickandmortyapi.com/api/{data}"))
                {
                    var apiResponse = await responseHttp.Content.ReadAsStringAsync();
                    var jsonSerializer = JsonSerializer.Deserialize<T>(apiResponse);
                    return jsonSerializer!;
                }

            }
        }

        public async Task<List<T>> GetListDataAsync<T>(string data)
        {

            var val = data.Split('/');

            using (var httpClient = new HttpClient())
            {
                using (var responseHttp = await httpClient.GetAsync($"https://rickandmortyapi.com/api/{data}"))
                {
                    var apiResponse = await responseHttp.Content.ReadAsStringAsync();

                    if (val.Count() < 2)
                    {
                        var jsonSerializer = JsonSerializer.Deserialize<T>(apiResponse);
                        List<T> r = new List<T>();
                        r.Add(jsonSerializer!);
                        return r;
                    }
                    else
                    {
                        var jsonSerializer = JsonSerializer.Deserialize<List<T>>(apiResponse);
                        return jsonSerializer!;
                    }
                }
            }
        }


    }
}
