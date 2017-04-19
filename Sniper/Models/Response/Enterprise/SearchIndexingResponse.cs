#if false
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace Sniper.Response.Enterprise
{
    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + ",nq}")]
    public class SearchIndexingResponse
    {
        public SearchIndexingResponse() { }

        public SearchIndexingResponse(IReadOnlyList<string> message)
        {
            Message = message;
        }

        public IReadOnlyList<string> Message
        {
            get;
        }

        internal string DebuggerDisplay => String.Format(CultureInfo.InvariantCulture, "Message: {0}", string.Join("\r\n", Message));
    }
}
#endif