#if false
using System.Diagnostics;
using System.Globalization;

namespace Sniper.Response
{
    /// <summary>
    /// Represents the response information from a <see cref="UserAdministrationClient.Rename"/> operation
    /// </summary>
    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + ",nq}")]
    public class UserRenameResponse
    {
        public UserRenameResponse() { }

        public UserRenameResponse(string message, string url)
        {
            Message = message;
            Url = url;
        }

        /// <summary>
        /// Message indiating if the Rename request was queued
        /// </summary>
        public string Message { get; protected set; }

        /// <summary>
        /// Url to the user that will be renamed
        /// </summary>
        public string Url { get; protected set; }

        internal string DebuggerDisplay => string.Format(CultureInfo.InvariantCulture, "Message: {0}", Message);
    }
}
#endif