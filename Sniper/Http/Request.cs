using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using static Sniper.WarningsErrors.MessageSuppression;

namespace Sniper.Http
{
    [SuppressMessage(Categories.Naming, MessageAttributes.TypeNamesShouldNotMatchNamespaces)]
    public class Request : IRequest
    {
        public Request()
        {
            Headers = new Dictionary<string, string>();
            Parameters = new Dictionary<string, string>();
            Timeout = TimeSpan.FromSeconds(100);
        }

        public object Body { get; set; }
        public Dictionary<string, string> Headers { get; }
        public HttpMethod Method { get; set; }
        public Dictionary<string, string> Parameters { get; }
        public Uri BaseAddress { get; set; }
        public Uri Endpoint { get; set; }
        public TimeSpan Timeout { get; set; }
        public string ContentType { get; set; }
    }
}
