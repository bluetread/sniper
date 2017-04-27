using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Net.Http;
using static Sniper.WarningsErrors.MessageSuppression;

namespace Sniper.Http
{
    public static class HttpMessageHandlerFactory
    {
        public static HttpMessageHandler CreateDefault()
        {
            return CreateDefault(null);
        }

        [SuppressMessage(Categories.Usage, MessageAttributes.ReviewUnusedParameters, MessageId = "proxy")]
        [SuppressMessage(Categories.Reliability, MessageAttributes.DisposeObjectsBeforeLosingScope)]
        public static HttpMessageHandler CreateDefault(IWebProxy proxy)
        {
            var handler = new HttpClientHandler
            {
                AllowAutoRedirect = false
            };
            return handler;
        }
    }
}