using System.Collections.Generic;

namespace RickAndMorty.Web.Services
{
    public interface IConsumeAPI
    {
        Task<List<T>> ConsumeApiAsync<T>(string url);
    }
}
