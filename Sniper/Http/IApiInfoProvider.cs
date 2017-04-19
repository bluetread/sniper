using static Sniper.WarningsErrors.MessageSuppression;
using System.Diagnostics.CodeAnalysis;

namespace Sniper.Http
{
    /// <summary>
    /// Provides a property for the Last recorded API information
    /// </summary>
    public interface IApiInfoProvider
    {
        /// <summary>
        /// Gets the latest API Info - this will be null if no API calls have been made
        /// </summary>
        /// <returns><seealso cref="ApiInfo"/> representing the information returned as part of an Api call</returns>
        [SuppressMessage(Categories.Design, MessageAttributes.UsePropertiesWhereAppropriate)]
        ApiInfo GetLastApiInfo();
    }
}
