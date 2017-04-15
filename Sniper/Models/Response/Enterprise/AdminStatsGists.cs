using System;
using System.Diagnostics;
using System.Globalization;

namespace Sniper.Response.Enterprise
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class AdminStatsGists
    {
        public AdminStatsGists() { }

        public AdminStatsGists(int totalGists, int privateGists, int publicGists)
        {
            TotalGists = totalGists;
            PrivateGists = privateGists;
            PublicGists = publicGists;
        }

        public int TotalGists
        {
            get;
        }

        public int PrivateGists
        {
            get;
        }

        public int PublicGists
        {
            get;
        }

        internal string DebuggerDisplay
        {
            get
            {
                return String.Format(CultureInfo.InvariantCulture, "TotalGists: {0} PrivateGists: {1} PublicGists: {2}", TotalGists, PrivateGists, PublicGists);
            }
        }
    }
}