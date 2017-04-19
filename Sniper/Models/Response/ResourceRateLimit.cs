#if false
using System.Diagnostics;
using System.Globalization;
using Sniper.Http;


namespace Sniper.Response
{
    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + ",nq}")]
    public class ResourceRateLimit
    {
        public ResourceRateLimit() { }

        public ResourceRateLimit(RateLimit core, RateLimit search)
        {
            Ensure.ArgumentNotNull(nameof(core), core);
            Ensure.ArgumentNotNull(nameof(search), search);

            Core = core;
            Search = search;
        }

        /// <summary>
        /// Rate limits for core API (rate limit for everything except Search API)
        /// </summary>
        public RateLimit Core { get; }

        /// <summary>
        /// Rate Limits for Search API
        /// </summary>
        public RateLimit Search { get; }

        internal string DebuggerDisplay => string.Format(CultureInfo.InvariantCulture, "Core: {0}; Search: {1} ", Core.DebuggerDisplay, Search.DebuggerDisplay);
    }
}
#endif