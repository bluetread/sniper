using System;
using System.Diagnostics;
using System.Globalization;
using Sniper.Http;
using Sniper.ToBeRemoved;

namespace Sniper.Response
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class LicenseMetadata
    {
        public LicenseMetadata(string key, string name, Uri url)
        {
            Ensure.ArgumentNotNullOrEmptyString(HttpKeys.Key, key);
            Ensure.ArgumentNotNullOrEmptyString(OldGitHubToBeRemoved.Name, name);
            Ensure.ArgumentNotNull(HttpKeys.Url, url);
            
            Key = key;
            Name = name;
            Url = url;
        }

        public LicenseMetadata()
        {
        }

        /// <summary>
        /// The 
        /// </summary>
        public string Key { get; protected set; }

        /// <summary>
        /// Friendly name of the license.
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// URL to retrieve details about a license.
        /// </summary>
        public Uri Url { get; protected set; }

        internal virtual string DebuggerDisplay
        {
            get
            {
                return string.Format(CultureInfo.InvariantCulture, "Key: {0} Name: {1}", Key, Name);
            }
        }
    }
}
