using RickAndMorty.Shared.Data;
using System.Collections.Generic;

namespace RickAndMorty.Web.Services
{
    public interface IConsumeAPI
    {

        Task<GeneralResponse<T>> GetListDataAsync<T>(string url);

        Task<T> GetIndividualDataAsync<T>(string url);

        Task<List<T>> GetListByEntity<T>(string url);

    }
}
