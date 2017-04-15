using System.Collections.Generic;
using System.Threading.Tasks;
using Sniper.Http;
using static Sniper.Constants;

namespace Sniper
{
    internal class Authenticator
    {
        private readonly Dictionary<AuthenticationType, IAuthenticationHandler> _authenticators =
            new Dictionary<AuthenticationType, IAuthenticationHandler>
            {
                { AuthenticationType.Anonymous, new AnonymousAuthenticator() },
                { AuthenticationType.Basic, new BasicAuthenticator() },
                { AuthenticationType.Oauth, new TokenAuthenticator() }
            };

        public Authenticator(ICredentialStore credentialStore)
        {
            Ensure.ArgumentNotNull(Authentication.CredentialStore, credentialStore);

            CredentialStore = credentialStore;
        }

        public async Task Apply(IRequest request)
        {
            Ensure.ArgumentNotNull(Authentication.Request, request);

            var credentials = await CredentialStore.GetCredentials().ConfigureAwait(false) ?? Credentials.Anonymous;
            _authenticators[credentials.AuthenticationType].Authenticate(request, credentials);
        }

        public ICredentialStore CredentialStore { get; set; }
    }
}
