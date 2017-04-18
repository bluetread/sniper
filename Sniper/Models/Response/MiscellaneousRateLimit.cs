#if false
using System.Diagnostics;
using System.Globalization;
using Sniper.Http;


namespace Sniper.Response
{
    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + ",nq}")]
    public class MiscellaneousRateLimit
    {
        public MiscellaneousRateLimit() { }

        public MiscellaneousRateLimit(ResourceRateLimit resources, RateLimit rate)
        {
            Ensure.ArgumentNotNull(nameof(resources), resources);
            Ensure.ArgumentNotNull(nameof(rate), rate);

            Resources = resources;
            Rate = rate;
        }

        /// <summary>
        /// Object of resources rate limits
        /// </summary>
        public ResourceRateLimit Resources { get; }

        /// <summary>
        /// Legacy rate limit - to be depreciated - https://developer.github.com/v3/rate_limit/#deprecation-notice
        /// </summary>
        public RateLimit Rate { get; }

        internal string DebuggerDisplay => Resources == null ? "No rates found" : string.Format(CultureInfo.InvariantCulture, Resources.DebuggerDisplay);
    }
}
#endif