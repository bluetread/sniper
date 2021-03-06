﻿using System;

namespace Sniper
{
    /// <summary>
    /// Extensions for converting between different time representations
    /// </summary>
    public static class UnixTimestampExtensions
    {
        private static readonly DateTimeOffset _epoch = new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero);

        /// <summary>
        /// Convert a Unix tick to a <see cref="DateTimeOffset"/> with UTC offset
        /// </summary>
        /// <param name="unixTime">UTC tick</param>
        public static DateTimeOffset FromUnixTime(this long unixTime)
        {
            return _epoch.AddSeconds(unixTime);
        }

        /// <summary>
        /// Convert <see cref="DateTimeOffset"/> with UTC offset to a Unix tick
        /// </summary>
        /// <param name="date">Date Time with UTC offset</param>
        public static long ToUnixTime(this DateTimeOffset date)
        {
            return Convert.ToInt64((date.ToUniversalTime() - _epoch).TotalSeconds);
        }
    }
}