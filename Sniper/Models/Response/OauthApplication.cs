using System.Diagnostics;
using System.Globalization;

namespace Sniper.Response
{
    /// <summary>
    /// Represents an oauth application.
    /// </summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class OauthApplication
    {
        public OauthApplication() { }

        public OauthApplication(string name, string url)
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

        internal string DebuggerDisplay
        {
            get { return string.Format(CultureInfo.InvariantCulture, "Name: {0}", Name); }
        }
    }
}
