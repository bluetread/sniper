using System;
using System.Diagnostics;
using System.Globalization;

namespace Sniper.Response
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class Emoji
    {
        public Emoji() { }

        public Emoji(string name, Uri url)
        {
            Ensure.ArgumentNotNullOrEmptyString(name, "name");
            Ensure.ArgumentNotNull(url, "url");

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
