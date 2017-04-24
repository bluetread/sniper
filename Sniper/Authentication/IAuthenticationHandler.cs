using Sniper.Http;

namespace Sniper
{
    public interface IAuthenticationHandler
    {
        IApiSiteInfo ApiSiteInfo { get; }
        ICredentials Credentials { get; }

        //void Authenticate(IApiSiteInfo apiSiteInfo, ICredentials credentials);
    }
}