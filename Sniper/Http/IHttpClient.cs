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
        IHttpResponse Send(IApiRequest request);

        /// <summary>
        /// Sends the specified request and returns a response.
        /// </summary>
        /// <param name="request">A <see cref="IApiRequest"/> that represents the HTTP request</param>
        /// <param name="cancellationToken">Used to cancel the request</param>
        /// <returns>A <see cref="Task" /> of <see cref="IHttpResponse"/></returns>
        Task<IHttpResponse> SendAsync(IApiRequest request, CancellationToken cancellationToken);
    }
}
