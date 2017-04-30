using Sniper.Http;
using System.Collections.Generic;

namespace Sniper
{
    public interface IAuthenticationHandler
    {
        ISiteInfo SiteInfo { get; }
        ICredentials Credentials { get; }
        System.Net.ICredentials NetworkCredentials { get; }
        Dictionary<string, string> AuthenticationParameters { get; }
    }
}