#if false
using System.Diagnostics;
using System.Globalization;

namespace Sniper.Response
{
    /// <summary>
    /// Represents an oauth application.
    /// </summary>
    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + ",nq}")]
    public class OAuthApplication
    {
        public OAuthApplication() { }

        public OAuthApplication(string name, string url)
        {
            Name = name;
            Url = url;
        }

        /// <summary>
        /// <see cref="Application"/> Name.
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// The Url of this <see cref="Application"/>.
        /// </summary>
        public string Url { get; protected set; }

        internal string DebuggerDisplay => string.Format(CultureInfo.InvariantCulture, "Name: {0}", Name);
    }
}
#endif