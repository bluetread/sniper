using Sniper.Authentication;

namespace Sniper.Http
{
    public static class CredentialsExtensions
    {
        public static string GetToken(this ICredentials credentials)
        {
            Ensure.ArgumentNotNull(AuthenticationKeys.Credentials, credentials);

            return credentials.Password;
        }
    }
}