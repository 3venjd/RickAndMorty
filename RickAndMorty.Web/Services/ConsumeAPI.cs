using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using RickAndMorty.Shared.Data;

namespace RickAndMorty.Web.Services
{
    public class ConsumeAPI : IConsumeAPI
    {


        public async Task<List<T>> GetDataAsync<T>(string data)
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync($"https://rickandmortyapi.com/api/{data}"))
                {

                    string apiResponse = await response.Content.ReadAsStringAsync();
                    JObject obj = JObject.Parse(apiResponse);
                    JToken test = "";
                    List<T> a = new List<T>();

                    if (obj["results"] != null)
                    {
                        test = obj["results"]!;
                        a = JsonConvert.DeserializeObject<List<T>>(test.ToString())!;
                    }
                    else 
                    {
                        a = JsonConvert.DeserializeObject<List<T>>(apiResponse)!;
                    }

                    return a;
                }
            }
        }

        public async Task<int> GetTotalPagesAsync(string data)
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync($"https://rickandmortyapi.com/api/{data}"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    JObject obj = JObject.Parse(apiResponse);
                    var pres =  obj["info"]!["pages"]!;
                    var  res = JsonConvert.DeserializeObject<int>(pres.ToString())!;
                    return res;
                }
            }
        }
    }
}
