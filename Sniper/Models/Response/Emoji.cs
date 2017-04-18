using System;
using System.Diagnostics;
using System.Globalization;
using Sniper.Http;
using Sniper.ToBeRemoved;

namespace Sniper.Response
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class Emoji
    {
        public Emoji() { }

        public Emoji(string name, Uri url)
        {
            Ensure.ArgumentNotNullOrEmptyString(OldGitHubToBeRemoved.Name, name);
            Ensure.ArgumentNotNull(HttpKeys.Url, url);

            Name = name;
            Url = url;
        }

        public string Name { get; }
        public Uri Url { get; }

        internal string DebuggerDisplay
        {
            get
            {
                return string.Format(CultureInfo.InvariantCulture, "Name {0} ", Name);
            }
        }
    }
}
