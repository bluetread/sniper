using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using Sniper.ToBeRemoved;

namespace Sniper.Response
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class CommitActivity
    {
        public CommitActivity() { }

        public CommitActivity(IEnumerable<WeeklyCommitActivity> activity)
        {
            Ensure.ArgumentNotNull(OldGitHubToBeRemoved.Activity, activity);

            Activity = new ReadOnlyCollection<WeeklyCommitActivity>(activity.ToList());
        }

        /// <summary>
        /// Returns the last year of commit activity grouped by week.
        /// </summary>
        public IReadOnlyList<WeeklyCommitActivity> Activity { get; }

        internal string DebuggerDisplay
        {
            get
            {
                return string.Format(CultureInfo.InvariantCulture,
                    "Weeks of activity: {0}", Activity.Count);
            }
        }
    }
}