using Sniper.Application.Parameters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Serialization;
using System.Security;
using static Sniper.WarningsErrors.MessageSuppression;

namespace Sniper.Http
{

    [Serializable]

    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + ",nq}")]
    public class RateLimit

        : ISerializable

    {
        public RateLimit() { }

        public RateLimit(IDictionary<string, string> responseHeaders)
        {
            Ensure.ArgumentNotNull(HttpKeys.ResponseParameters.ResponseHeaders, responseHeaders);
            
            Limit = (int)GetHeaderValueAsInt32Safe(responseHeaders, "X-RateLimit-Limit");
            Remaining = (int)GetHeaderValueAsInt32Safe(responseHeaders, "X-RateLimit-Remaining");
            ResetAsUtcEpochSeconds = GetHeaderValueAsInt32Safe(responseHeaders, "X-RateLimit-Reset");
        }

        public RateLimit(int limit, int remaining, long reset)
        {
            Ensure.ArgumentNotNull(nameof(limit), limit);
            Ensure.ArgumentNotNull(nameof(remaining), remaining);
            Ensure.ArgumentNotNull(nameof(reset), reset);

            Limit = limit;
            Remaining = remaining;
            ResetAsUtcEpochSeconds = reset;
        }

        /// <summary>
        /// The maximum number of requests that the consumer is permitted to make per hour.
        /// </summary>
        public int Limit { get; private set; }

        /// <summary>
        /// The number of requests remaining in the current rate limit window.
        /// </summary>
        public int Remaining { get; private set; }

        /// <summary>
        /// The date and time at which the current rate limit window resets
        /// </summary>
        [Parameter(Key = ParameterKeys.IgnoreField)]
        public DateTimeOffset Reset => ResetAsUtcEpochSeconds.FromUnixTime();

        /// <summary>
        /// The date and time at which the current rate limit window resets - in UTC epoch seconds
        /// </summary>
        [SuppressMessage(Categories.Performance, MessageAttributes.AvoidUncalledPrivateCode)]
        [Parameter(Key = ParameterKeys.Reset)]
        public long ResetAsUtcEpochSeconds { get; private set; }

        private static long GetHeaderValueAsInt32Safe(IDictionary<string, string> responseHeaders, string key)
        {
            string value;
            long result;
            return !responseHeaders.TryGetValue(key, out value) || value == null || !long.TryParse(value, out result)
                ? 0
                : result;
        }


        protected RateLimit(SerializationInfo info, StreamingContext context)
        {
            Ensure.ArgumentNotNull(nameof(info), info);

            Limit = info.GetInt32(ParameterKeys.Limit);
            Remaining = info.GetInt32(ParameterKeys.Remaining);
            ResetAsUtcEpochSeconds = info.GetInt64(ParameterKeys.ResetAsUtcEpochSeconds);
        }

        [SecurityCritical]
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            Ensure.ArgumentNotNull(nameof(info), info);

            info.AddValue(ParameterKeys.Limit, Limit);
            info.AddValue(ParameterKeys.Remaining, Remaining);
            info.AddValue(ParameterKeys.ResetAsUtcEpochSeconds, ResetAsUtcEpochSeconds);
        }


        internal string DebuggerDisplay => string.Format(CultureInfo.InvariantCulture, "Limit {0}, Remaining {1}, Reset {2} ", Limit, Remaining, Reset);

        /// <summary>
        /// Allows you to clone RateLimit
        /// </summary>
        /// <returns>A clone of <seealso cref="RateLimit"/></returns>
        public RateLimit Clone()
        {
            return new RateLimit
            {
                Limit = Limit,
                Remaining = Remaining,
                ResetAsUtcEpochSeconds = ResetAsUtcEpochSeconds
            };
        }
    }
}
