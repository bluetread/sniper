using System;
using System.Diagnostics.CodeAnalysis;
using Sniper.Application.Messages;
using static Sniper.WarningsErrors.MessageSuppression;

namespace Sniper
{
    /// <summary>
    ///   Ensure input parameters
    /// </summary>
    internal static class Ensure
    {
        /// <summary>
        /// Checks an argument to ensure it isn't null.
        /// </summary>
        /// <param name = "name">The name of the argument</param>
        /// <param name = "value">The argument value to check</param>
        [SuppressMessage(Categories.Usage, MessageAttributes.ReviewUnusedParameters)]
        public static void ArgumentNotNull(string name, [ValidatedNotNull]object value)
        {
            if (value != null) return;

            throw new ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Checks a string argument to ensure it isn't null or empty.
        /// </summary>
        /// <param name = "name">The name of the argument</param>
        /// <param name = "value">The argument value to check</param>
        public static void ArgumentNotNullOrEmptyString(string name, [ValidatedNotNull]string value)
        {
            ArgumentNotNull(name, value);
            if (!string.IsNullOrWhiteSpace(value)) return;

            throw new ArgumentException(MessageKeys.EmptyParameter, nameof(name));
        }

        /// <summary>
        /// Checks a timespan argument to ensure it is a positive value.
        /// </summary>
        /// <param name = "value">The argument value to check</param>
        /// <param name = "name">The name of the argument</param>
        [SuppressMessage(Categories.Performance, MessageAttributes.AvoidUncalledPrivateCode)]
        public static void GreaterThanZero(string name, [ValidatedNotNull]TimeSpan value)
        {
            ArgumentNotNull(name, value);

            if (value.TotalMilliseconds > 0) return;

            throw new ArgumentException(MessageKeys.TimespanZero, name);
        }
    }

    [AttributeUsage(AttributeTargets.Parameter)]
    internal sealed class ValidatedNotNullAttribute : Attribute
    {
    }
}
