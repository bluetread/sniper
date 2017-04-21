using System.Threading;
using System.Threading.Tasks;
using Sniper.Http;

namespace Sniper
{
    public static class HttpClientExtensions
    {
        public static Task<IResponse> Send(this IHttpClient httpClient, IRequest request)
        {
            Ensure.ArgumentNotNull(nameof(httpClient), httpClient);
            Ensure.ArgumentNotNull(nameof(request), request);

            return httpClient.Send(request, CancellationToken.None);
        }
    }
}