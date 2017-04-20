#if false
using System;
using System.Diagnostics;
using System.Globalization;

namespace Sniper.Response.Enterprise
{
    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + ",nq}")]
    public class LicenseInfo
    {
        public LicenseInfo() { }

        public LicenseInfo(int seats, int seatsUsed, int seatsAvailable, string kind, int daysUntilExpiration, DateTimeOffset expireAt)
        {
            Seats = seats;
            SeatsUsed = seatsUsed;
            SeatsAvailable = seatsAvailable;
            Kind = kind;
            DaysUntilExpiration = daysUntilExpiration;
            ExpireAt = expireAt;
        }

        public int Seats
        {
            get;
        }

        public int SeatsUsed
        {
            get;
        }

        public int SeatsAvailable
        {
            get;
        }

        public string Kind
        {
            get;
        }

        public int DaysUntilExpiration
        {
            get;
        }

        public DateTimeOffset ExpireAt
        {
            get;
        }

        internal string DebuggerDisplay => String.Format(CultureInfo.InvariantCulture, "Seats: {0} SeatsUsed: {1} DaysUntilExpiration: {2}", Seats, SeatsUsed, DaysUntilExpiration);
    }
}
#endif