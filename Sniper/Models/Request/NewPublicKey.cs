using System.Diagnostics;
using System.Globalization;
using Sniper.Http;
using Sniper.ToBeRemoved;

namespace Sniper.Request
{
    /// <summary>
    /// Used to create a public SSH key
    /// </summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class NewPublicKey
    {
        public NewPublicKey()
        { }

        public NewPublicKey(string title, string key)
        {
            Ensure.ArgumentNotNullOrEmptyString(OldGitHubToBeRemoved.Title, title);
            Ensure.ArgumentNotNullOrEmptyString(HttpKeys.Key, key);

            Title = title;
            Key = key;
        }

        /// <summary>
        /// The title of the key
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The Key data
        /// </summary>
        public string Key { get; set; }

        internal string DebuggerDisplay
        {
            get
            {
                return string.Format(CultureInfo.InvariantCulture, "Title: {0} Key: {1}", Title, Key);
            }
        }
    }
}