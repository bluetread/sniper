using Sniper.Http;

namespace Sniper
{
    internal class AnonymousAuthenticator : IAuthenticationHandler
    {
        public void Authenticate(IRequest request, ICredentials credentials)
        {
            // Do nothing. Retain your anonymity.
        }
    }
}
