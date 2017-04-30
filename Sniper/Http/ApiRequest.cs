using Sniper.Types;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Sniper.Http
{
    public class ApiRequest : IApiRequest
    {
        public object Data { get; set; }
        public IAuthenticationHandler AuthenticationHandler { get; set; }
        public IDictionary<string, string> Headers { get; set; } = new Dictionary<string, string>();
        public HttpMethod Method { get; set; } = HttpMethod.Get;
        public IDictionary<string, string> Parameters { get; } = new Dictionary<string, string>();
        public string Route { get; set; }
        public Uri BaseAddress { get; set; }
        public TimeSpan Timeout { get; set; } = TimeSpan.FromSeconds(15);
        public string ContentType { get; set; } = MimeTypes.ApplicationJson;
    }
}
