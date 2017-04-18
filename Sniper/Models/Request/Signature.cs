#if false
using System.Diagnostics;
using System.Globalization;

namespace Sniper.Request
{
    /// <summary>
    /// Information about an author or committer.
    /// </summary>
    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + ",nq}")]
    public class Signature
    {
        /// <summary>
        /// Creates an instance of Signature with the required values.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="email"></param>
        public Signature(string name, string email)
        {
            Ensure.ArgumentNotNullOrEmptyString(nameof(name), name);
            Ensure.ArgumentNotNullOrEmptyString(nameof(email), email);

            Name = name;
            Email = email;
        }

        /// <summary>
        /// The full name of the author/committer.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The email address of the author/committer.
        /// </summary>
        public string Email { get; }

        internal string DebuggerDisplay => string.Format(CultureInfo.InvariantCulture, "Name: {0} Email: {1}", Name, Email);
    }
}
#endif