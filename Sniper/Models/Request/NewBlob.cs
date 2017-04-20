#if false
using System.Diagnostics;
using System.Globalization;
using Sniper.Response;

namespace Sniper.Request
{
    /// <summary>
    /// Used to create a Blob.
    /// </summary>
    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + ",nq}")]
    public class NewBlob
    {
        /// <summary>
        /// The content of the blob.
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// The encoding of the blob.
        /// </summary>
        public EncodingType Encoding { get; set; }

        internal string DebuggerDisplay => string.Format(CultureInfo.InvariantCulture, "Encoding: {0}", Encoding);
    }
}
#endif