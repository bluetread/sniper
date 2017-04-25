using System.Collections.Generic;
using System.Threading.Tasks;
using Sniper.Http;

namespace Sniper
{
    internal class Authenticator
    {
        private readonly Dictionary<AuthenticationType, IAuthenticationHandler> _authenticators =
            new Dictionary<AuthenticationType, IAuthenticationHandler>
            {
                { AuthenticationType.AccessToken, new AccessTokenAuthenticator() },
                { AuthenticationType.Basic, new BasicAuthenticator() },
                { AuthenticationType.Cookie, new CookieAuthenticator() },
                { AuthenticationType.ServiceToken, new ServiceTokenAuthenticator() }
            };

        public Authenticator(ICredentialStore credentialStore)
        {
            Ensure.ArgumentNotNull(nameof(credentialStore), credentialStore);

            CredentialStore = credentialStore;
        }

        public async Task Apply(IRequest request)
        {
            Ensure.ArgumentNotNull(nameof(request), request);

            var credentials = await CredentialStore.GetCredentials().ConfigureAwait(false) ?? Credentials.CookieCredentials;
            _authenticators[credentials.AuthenticationType].Authenticate(request, credentials);
        }

        public ICredentialStore CredentialStore { get; set; }
    }
}
