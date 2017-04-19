﻿#if false
using System.Diagnostics;
using System.Globalization;

namespace Sniper.Request
{
    /// <summary>
    /// Used as part of the request to retrieve all organizations.
    /// </summary>
    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + ",nq}")]
    public class OrganizationRequest : RequestParameters
    {
        /// <summary>
        /// Intializes a new instance of the <see cref="OrganizationRequest"/> class.
        /// </summary>
        /// <param name="since">The integer Id of the last Organization that you've seen.</param>
        public OrganizationRequest(int since)
        {
            Ensure.ArgumentNotNull(nameof(since), since);
            
            Since = since;
        }

        /// <summary>
        /// Gets or sets the integer Id of the last Organization that you've seen.
        /// </summary>
        public long Since { get; set; }

        internal string DebuggerDisplay => string.Format(CultureInfo.InvariantCulture, "Since: {0} ", Since);
    }
}
#endif