using Sniper.Contracts.Entities.Common;
using System.Collections.ObjectModel;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    ///<summary>
    ///
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Programs/meta">API documentation - Program</a>
    /// </remarks>
    public class Program : General, IHasProjects
    {
        #region Required for Create

        [RequiredForCreate]
        public override string Name { get; set; }

        #endregion

        public Collection<Project> Projects { get; set; }
    }
}