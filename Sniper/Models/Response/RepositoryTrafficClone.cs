#if false
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Sniper.Response
{
    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + ",nq}")]
    public class RepositoryTrafficCloneSummary
    {
        public RepositoryTrafficCloneSummary() { }

        [SuppressMessage(Categories.Naming, "CA1704:IdentifiersShouldBeSpelledCorrectly", Justification = "It's a property from the api.")]
        public RepositoryTrafficCloneSummary(int count, int uniques, IReadOnlyList<RepositoryTrafficClone> clones)
        {
            Count = count;
            Uniques = uniques;
            Clones = clones;
        }

        public int Count { get; protected set; }

        [SuppressMessage(Categories.Naming, "CA1704:IdentifiersShouldBeSpelledCorrectly", Justification = "It's a property from the api.")]
        public int Uniques { get; protected set; }

        public IReadOnlyList<RepositoryTrafficClone> Clones { get; protected set; }

        internal string DebuggerDisplay => string.Format(CultureInfo.InvariantCulture, "Number: {0} Uniques: {1}", Count, Uniques);
    }

    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + ",nq}")]
    public class RepositoryTrafficClone
    {
        public RepositoryTrafficClone() { }

        [SuppressMessage(Categories.Naming, "CA1704:IdentifiersShouldBeSpelledCorrectly", Justification = "It's a property from the api.")]
        public RepositoryTrafficClone(DateTimeOffset timestamp, int count, int uniques)
        {
            Timestamp = timestamp;
            Count = count;
            Uniques = uniques;
        }

        public DateTimeOffset Timestamp { get; protected set; }

        public int Count { get; protected set; }

        [SuppressMessage(Categories.Naming, "CA1704:IdentifiersShouldBeSpelledCorrectly", Justification = "It's a property from the api.")]
        public int Uniques { get; protected set; }

        internal string DebuggerDisplay => string.Format(CultureInfo.InvariantCulture, "Number: {0} Uniques: {1}", Count, Uniques);
    }

    public enum TrafficDayOrWeek
    {
        Day,
        Week
    }
}
#endif