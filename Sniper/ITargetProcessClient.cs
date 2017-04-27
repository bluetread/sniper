using Sniper.Http;
using System.Collections.Generic;

namespace Sniper
{
    /// <summary>
    /// A Client for the TargetProcess API. You can read more about the api here: https://dev.targetprocess.com/docs/rest-getting-started.   
    /// </summary>
    public interface ITargetProcessClient 
    {
        //KeyValuePair<string, string> ResponseFormatParameter { get; }
        IDictionary<string, string> DefaultQueryParameters { get; }
        IApiSiteInfo ApiSiteInfo { get; }
    }
}
