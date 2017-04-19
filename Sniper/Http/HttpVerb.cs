using System.Net.Http;

namespace Sniper.Http
{
    internal static class HttpVerb
    {
        internal static HttpMethod Patch { get; } = new HttpMethod("PATCH");
    }
}
