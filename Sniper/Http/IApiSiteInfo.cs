using System.Collections.Generic;
using System.Net.Http;
using static Sniper.Http.HttpResponseFormats;

namespace Sniper.Http
{
    public interface IApiSiteInfo
    {
        HttpMethod Method { get; }
        IDictionary<string, string> Parameters { get;  }
        string Route { get;  }
        ResponseFormat ResponseFormat { get; }
        ICollection<string> Includes { get; }
        ICollection<string> Excludes { get; }
    }
}
