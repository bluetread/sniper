namespace Sniper.Http
{
    public static class CredentialsExtensions
    {
        public static string GetToken(this ICredentials credentials)
        {
            Ensure.ArgumentNotNull(nameof(credentials), credentials);

            return credentials.Password;
        }
    }
}