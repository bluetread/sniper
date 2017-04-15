using System.Diagnostics.CodeAnalysis;

namespace Sniper.Http
{
    public class Credentials : ICredentials
    {
        [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes"
            , Justification = "Credentials is immutable")]
        public static readonly Credentials Anonymous = new Credentials();

        private Credentials()
        {
            AuthenticationType = AuthenticationType.Anonymous;
        }

        public Credentials(string token)
        {
            Ensure.ArgumentNotNullOrEmptyString(token, "token");

            Login = null;
            Password = token;
            AuthenticationType = AuthenticationType.Oauth;
        }

        public Credentials(string login, string password)
        {
            Ensure.ArgumentNotNullOrEmptyString(login, "login");
            Ensure.ArgumentNotNullOrEmptyString(password, "password");

            Login = login;
            Password = password;
            AuthenticationType = AuthenticationType.Basic;
        }

        public string Login
        {
            get;
        }

        public string Password
        {
            get;
        }

        public AuthenticationType AuthenticationType
        {
            get;
        }
    }
}