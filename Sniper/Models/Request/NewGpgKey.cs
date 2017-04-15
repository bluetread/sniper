using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Sniper.Request
{
    [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Gpg")]
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class NewGpgKey
    {
        public NewGpgKey()
        {
        }

        public NewGpgKey(string publicKey)
        {
            Ensure.ArgumentNotNullOrEmptyString(publicKey, "publicKey");

            ArmoredPublicKey = publicKey;
        }

        public string ArmoredPublicKey { get; set; }

        internal string DebuggerDisplay
        {
            get { return string.Format(CultureInfo.InvariantCulture, "ArmoredPublicKey: {0}", ArmoredPublicKey); }
        }
    }
}
