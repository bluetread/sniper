using Sniper.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sniper
{
    /// <summary>
    /// A Client for the TargetProcess API. You can read more about the api here: https://dev.targetprocess.com/docs/rest-getting-started.
    /// </summary>
    public interface ITargetProcessClient
    {
        //KeyValuePair<string, string> ResponseFormatParameter { get; }
        IDictionary<string, string> DefaultQueryParameters { get; }

        IApiSiteInfo ApiSiteInfo { get; }

        IApiResponse<T> CreateData<T>(Entity entity);
        Task<IApiResponse<T>> CreateDataAsync<T>(Entity entity);
        IApiResponse<T> DeleteData<T>(int id);
        Task<IApiResponse<T>> DeleteDataAsync<T>(Entity entity);
        IApiResponse<T> GetData<T>(int? id = null);
        Task<IApiResponse<T>> GetDataAsync<T>();
        IApiResponse<T> UpdateData<T>(Entity entity);
        Task<IApiResponse<T>> UpdateDataAsync<T>(Entity entity);

        IAuthenticationHandler AuthenticationHandler { get; }
    }
}