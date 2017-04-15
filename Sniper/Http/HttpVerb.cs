using System.Net.Http;

namespace Sniper.Http
{
    internal static class HttpVerb
    {
        private static readonly HttpMethod _patch = new HttpMethod("PATCH");

        internal static HttpMethod Patch
        {
            get { return _patch; }
        }
    }
}
