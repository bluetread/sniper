using static Sniper.WarningsErrors.MessageSuppression;
using System.Diagnostics.CodeAnalysis;

namespace Sniper.Http
{
    /// <summary>
    /// Container for the static <see cref="Empty"/> method that represents an
    /// intentional empty request body to avoid overloading <code>null</code>.
    /// </summary>
    public static class RequestBody
    {
        [SuppressMessage(Categories.Usage, MessageAttributes.NonConstantFieldsShouldNotBeVisible)]
        public static object Empty = new object();
    }
}