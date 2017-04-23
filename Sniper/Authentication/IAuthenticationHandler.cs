using Sniper.Http;

namespace Sniper
{
    internal interface IAuthenticationHandler
    {
        IApiSiteInfo ApiSiteInfo { get; }
        ICredentials Credentials { get; }

        void Authenticate(IApiSiteInfo apiSiteInfo, ICredentials credentials);
    }
}