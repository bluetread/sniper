using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using static Sniper.WarningsErrors.MessageSuppression;

namespace Sniper.Http
{
    /// <summary>
    /// Abstraction for interacting with credentials
    /// </summary>
    public interface ICredentialStore
    {
        /// <summary>
        /// Retrieve the credentials from the underlying store
        /// </summary>
        /// <returns>A continuation containing credentials</returns>
        [SuppressMessage(Categories.Design, MessageAttributes.UsePropertiesWhereAppropriate)]
        Task<Credentials> GetCredentials();
    }
}
