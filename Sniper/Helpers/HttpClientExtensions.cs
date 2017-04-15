using System.Threading;
using System.Threading.Tasks;
using Sniper.Http;

namespace Sniper
{
    public static class HttpClientExtensions
    {
        public static Task<IResponse> Send(this IHttpClient httpClient, IRequest request)
        {
            Ensure.ArgumentNotNull(httpClient, "httpClient");
            Ensure.ArgumentNotNull(request, "request");

            return httpClient.Send(request, CancellationToken.None);
        }
    }
}