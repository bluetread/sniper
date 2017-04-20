using Sniper.Authentication;
using System.Threading.Tasks;

namespace Sniper.Http
{
    /// <summary>
    /// Abstraction for interacting with credentials
    /// </summary>
    public class InMemoryCredentialStore : ICredentialStore
    {
        private readonly Credentials _credentials;

        /// <summary>
        /// Create an instance of the InMemoryCredentialStore
        /// </summary>
        /// <param name="credentials"></param>
        public InMemoryCredentialStore(Credentials credentials)
        {
            Ensure.ArgumentNotNull(AuthenticationKeys.Credentials, credentials);
            
            _credentials = credentials;
        }

        /// <summary>
        /// Retrieve the credentials from the underlying store
        /// </summary>
        /// <returns>A continuation containing credentials</returns>
        public Task<Credentials> GetCredentials()
        {
            return Task.FromResult(_credentials);
        }
    }
}