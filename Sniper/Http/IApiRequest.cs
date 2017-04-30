using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Sniper.Http
{
    public interface IApiRequest
    {
        object Data { get; set; }
        IAuthenticationHandler AuthenticationHandler { get; }
        IDictionary<string, string> Headers { get; }
        HttpMethod Method { get; }
        IDictionary<string, string> Parameters { get; }
        Uri BaseAddress { get; }
        string Route { get; }
        //Uri Endpoint { get; }
        TimeSpan Timeout { get; }
        string ContentType { get; }
    }
}