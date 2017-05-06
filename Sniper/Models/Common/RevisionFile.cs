using Sniper.Application;
using static Sniper.CustomAttributes.CustomAttributes;
using static Sniper.TargetProcess.Common.Enumerations;

namespace Sniper.Common
{
    ///<summary>
    /// A source file included to Revision.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/RevisionFiles/meta">API documentation - RevisionFile</a>
    /// </remarks>
    public class RevisionFile : Entity
    {
        public string FileName { get; set; }
        public FileAction FileAction { get; set; }

        #region Required for Create

        [RequiredForCreate(JsonProperties.Id)]
        public Revision Revision { get; set; }
        
        #endregion
    }
}