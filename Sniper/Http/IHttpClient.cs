using System;
using System.Threading;
using System.Threading.Tasks;

namespace Sniper.Http
{
    public interface IHttpClient : IDisposable
    {
        /// <summary>
        /// Sends the specified request and returns a response.
        /// </summary>
        /// <param name="request">A <see cref="IApiRequest"/> that represents the HTTP request</param>
        /// <returns>A <see cref="IHttpResponse"/></returns>
        IHttpResponse GetData(IApiRequest request);

        /// <summary>
        /// Sends the specified request and returns a response.
        /// </summary>
        /// <param name="request">A <see cref="IApiRequest"/> that represents the HTTP request</param>
        /// <returns>A <see cref="Task" /> of <see cref="IHttpResponse"/></returns>
        Task<IHttpResponse> GetDataAsync(IApiRequest request);

        /// <summary>
        /// Sends the specified request and returns a response.
        /// </summary>
        /// <param name="request">A <see cref="IApiRequest"/> that represents the HTTP request</param>
        /// <param name="cancellationToken">Used to cancel the request</param>
        /// <returns>A <see cref="Task" /> of <see cref="IHttpResponse"/></returns>
        Task<IHttpResponse> GetDataAsync(IApiRequest request, CancellationToken cancellationToken);

        /// <summary>
        /// Sends the specified request and returns a response.
        /// </summary>
        /// <param name="request">A <see cref="IApiRequest"/> that represents the HTTP request</param>
        /// <returns>A <see cref="IHttpResponse"/></returns>
        IHttpResponse PostData(IApiRequest request);

        /// <summary>
        /// Sends the specified request and returns a response.
        /// </summary>
        /// <param name="request">A <see cref="IApiRequest"/> that represents the HTTP request</param>
        /// <returns>A <see cref="IHttpResponse"/></returns>
        Task<IHttpResponse> PostDataAsync(IApiRequest request);
    }
}
