using Sniper.Http;

namespace Sniper
{
    //TODO: Not yet implemented
    internal class CookieAuthenticator : IAuthenticationHandler
    {
        public void Authenticate(IRequest request, ICredentials credentials)
        {
            Ensure.ArgumentNotNull(nameof(request), request);
            Ensure.ArgumentNotNull(nameof(credentials), credentials);
        }
    }
}
