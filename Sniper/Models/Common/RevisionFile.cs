using Sniper.Contracts;
using static Sniper.TargetProcess.Enumerations;

namespace Sniper.Common
{
    ///<summary>
    /// A source file included to Revision.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/RevisionFiles/meta">API documentation - RevisionFile</a>
    /// </remarks>
    public class RevisionFile :IHasId
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public FileAction FileAction { get; set; }
        public Revision Revision { get; set; }
    }
}
