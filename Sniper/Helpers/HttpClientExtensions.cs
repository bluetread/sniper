using Sniper.Http;
using System.Threading;
using System.Threading.Tasks;


namespace Sniper
{
    public static class HttpClientExtensions
    {
        public static Task<IResponse> Send(this IHttpClient httpClient, IRequest request)
        {
            Ensure.ArgumentNotNull(nameof(httpClient), httpClient);
            Ensure.ArgumentNotNull(HttpKeys.RequestParameters.Request, request);

            return httpClient.Send(request, CancellationToken.None);
        }
    }
}