using Sniper.Configuration;

namespace Sniper
{
    public static class AuthenticatorFactory
    {
        public static IAuthenticationHandler GetAuthenticationHandlerFromConfig()
        {
            return GetAuthenticationHandler(ConfigurationData.Instance.Credentials.AuthenticationType);
        }

        public static IAuthenticationHandler GetAuthenticationHandler(AuthenticationType authenticationType)
        {
            switch (authenticationType)
            {
                case AuthenticationType.AccessToken: return new AccessTokenAuthenticator();
                case AuthenticationType.Anonymous: return new AnonymousAuthenticator();
                case AuthenticationType.Cookie: return new CookieAuthenticator();
                case AuthenticationType.Basic: return new BasicAuthenticator();
                case AuthenticationType.ServiceToken: return new ServiceTokenAuthenticator();
                // Check config value for "Unknown", otherwise could get caught in a recursive loop
                case AuthenticationType.Unknown:
                    return GetAuthenticationHandler(
                        ConfigurationData.Instance.Credentials.AuthenticationType == AuthenticationType.Unknown
                        ? AuthenticationType.Anonymous
                        : ConfigurationData.Instance.Credentials.AuthenticationType);

                default: return new AnonymousAuthenticator();
            }
        }
    }
}