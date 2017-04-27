using Sniper.Http;

namespace Sniper.Configuration
{
    public interface IConfigurationData
    {
        ICredentials Credentials { get; }
        ISiteInfo SiteInfo { get; }
    }
}