using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using RickAndMorty.Shared.Data;

namespace RickAndMorty.Web.Services
{
    public class ConsumeAPI : IConsumeAPI
    {
        public async Task<List<T>> ConsumeApiAsync<T>(string url)
        {
            using (var httpClient = new HttpClient())
            {
                //string fullUrl = $"https://rickandmortyapi.com/api/{url}";
                using (var response = await httpClient.GetAsync(url))
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
    }
}
