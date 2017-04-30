namespace Sniper
{
    //Base class sets all the necessary properties for ServiceToken Authentication.
    internal class ServiceTokenAuthenticator : TokenAuthenticatorBase
    {
        public ServiceTokenAuthenticator() { }

        public ServiceTokenAuthenticator(string token) : base(token) { }
    }
}