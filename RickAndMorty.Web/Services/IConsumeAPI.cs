using System.Collections.Generic;

namespace RickAndMorty.Web.Services
{
    public interface IConsumeAPI
    {

        Task<int> GetTotalPagesAsync(string url);

        Task<List<T>> GetDataAsync<T>(string url);
    }
}
