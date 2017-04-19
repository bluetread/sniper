#if false
using System.Diagnostics.CodeAnalysis;

namespace Sniper.Response
{
    /// <summary>
    /// The possible repository content types.
    /// </summary>
    public enum ContentType
    {
        File,
        [SuppressMessage(Categories.Naming, "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dir", Justification = "Matches the value returned by the API")]
        Dir,
        Symlink,
        Submodule
    }
}
#endif