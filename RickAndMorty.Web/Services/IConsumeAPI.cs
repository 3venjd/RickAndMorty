using System.Collections.Generic;

namespace RickAndMorty.Web.Services
{
    public interface IConsumeAPI
    {

        Task<List<T>> GetListDataAsync<T>(string url);

        Task<T> GetIndividualDataAsync<T>(string url);

    }
}
