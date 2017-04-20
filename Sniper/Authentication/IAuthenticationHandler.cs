using Sniper.Http;

namespace Sniper
{
    internal interface IAuthenticationHandler
    {
        void Authenticate(IRequest request, ICredentials credentials);
    }
}