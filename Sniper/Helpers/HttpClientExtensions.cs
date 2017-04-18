using System.Threading;
using System.Threading.Tasks;
using Sniper.Http;
using Sniper.ToBeRemoved;

namespace Sniper
{
    public static class HttpClientExtensions
    {
        public static Task<IResponse> Send(this IHttpClient httpClient, IRequest request)
        {
            Ensure.ArgumentNotNull(OldGitHubToBeRemoved.HttpClient, httpClient);
            Ensure.ArgumentNotNull(HttpKeys.RequestParameters.Request, request);

            return httpClient.Send(request, CancellationToken.None);
        }
    }
}