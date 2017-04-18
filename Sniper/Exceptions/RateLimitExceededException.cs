using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Security;
using Sniper.Http;

namespace Sniper
{
    /// <summary>
    /// Exception thrown when GitHub API Rate limits are exceeded.
    /// </summary>
    /// <summary>
    /// <para>
    /// For requests using Basic Authentication or OAuth, you can make up to 5,000 requests per hour. For
    /// unauthenticated requests, the rate limit allows you to make up to 60 requests per hour.
    /// </para>
    /// <para>See http://developer.github.com/v3/#rate-limiting for more details.</para>
    /// </summary>

    [Serializable]

    [SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors",
        Justification = "These exceptions are specific to the GitHub API and not general purpose exceptions")]
    public class RateLimitExceededException : ForbiddenException
    {
        private readonly RateLimit _rateLimit;

        /// <summary>
        /// Constructs an instance of RateLimitExceededException
        /// </summary>
        /// <param name="response">The HTTP payload from the server</param>
        public RateLimitExceededException(IResponse response) : this(response, null)
        {
        }

        /// <summary>
        /// Constructs an instance of RateLimitExceededException
        /// </summary>
        /// <param name="response">The HTTP payload from the server</param>
        /// <param name="innerException">The inner exception</param>
        public RateLimitExceededException(IResponse response, Exception innerException) : base(response, innerException)
        {
            Ensure.ArgumentNotNull(HttpKeys.ResponseParameters.Response, response);

            _rateLimit = response.ApiInfo.RateLimit;
        }

        /// <summary>
        /// The maximum number of requests that the consumer is permitted to make per hour.
        /// </summary>
        public int Limit => _rateLimit.Limit;

        /// <summary>
        /// The number of requests remaining in the current rate limit window.
        /// </summary>
        public int Remaining => _rateLimit.Remaining;

        /// <summary>
        /// The date and time at which the current rate limit window resets
        /// </summary>
        public DateTimeOffset Reset => _rateLimit.Reset;

        // TODO: Might be nice to have this provide a more detailed message such as what the limit is,
        // how many are remaining, and when it will reset. I'm too lazy to do it now.
        //public override string Message => ApiErrorMessageSafe ?? "API Rate Limit exceeded";

     

        [SecurityCritical]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);

            info.AddValue("RateLimit", _rateLimit);
        }

    }
}
