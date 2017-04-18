#if false
using System.Diagnostics;
using System.Globalization;

namespace Sniper.Response
{
    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + ",nq}")]
    public class BlobReference
    {
        public BlobReference() { }

        public BlobReference(string sha)
        {
            Sha = sha;
        }

        /// <summary>
        /// The SHA of the blob.
        /// </summary>
        public string Sha { get; protected set; }

        internal string DebuggerDisplay => string.Format(CultureInfo.InvariantCulture, "Sha: {0}", Sha);
    }
}
#endif