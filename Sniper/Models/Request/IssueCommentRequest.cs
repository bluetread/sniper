using System;
using System.Diagnostics;
using System.Globalization;

namespace Sniper.Request
{
    /// <summary>
    /// Used to filter issue comments.
    /// </summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class IssueCommentRequest : RequestParameters
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssueCommentRequest"/> class.
        /// </summary>
     
        /// <summary>
        /// Can be either asc or desc. Default: asc.
        /// </summary>
        public SortDirection Direction { get; set; }

        /// <summary>
        /// Only comments updated at or after this time are returned. This is a timestamp in ISO 8601 format: YYYY-MM-DDTHH:MM:SSZ.
        /// </summary>
        public DateTimeOffset? Since { get; set; }

        internal string DebuggerDisplay
        {
            get { return string.Format(CultureInfo.InvariantCulture, "Sort: Direction: {0}, Since: {1}", Direction, Since); }
        }
    }
}
