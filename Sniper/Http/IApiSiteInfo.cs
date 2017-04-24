using System.Collections.Generic;
using System.Net.Http;

namespace Sniper.Http
{
    public interface IApiSiteInfo : ISiteInfo
    {
        HttpMethod Method { get; set; }
        Dictionary<string, string> Parameters { get;  }
        string Route { get; set; } 

        //object Body { get; set; }
        //Dictionary<string, string> Headers { get; }
        //Uri BaseAddress { get; }
        //Uri Endpoint { get; }
        //TimeSpan Timeout { get; }
        //string ContentType { get; }
    }
}
