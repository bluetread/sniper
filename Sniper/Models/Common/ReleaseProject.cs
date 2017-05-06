using Sniper.Contracts.Entities.Common;

namespace Sniper.Common
{
    ///<summary>
    /// Project assigned to a release
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/ReleaseProjects/meta">API documentation - ReleaseProject</a>
    /// </remarks>
    public class ReleaseProject : Entity, IHasProject, IHasRelease
    {
        public Project Project { get; set; }
        public Release Release { get; set; }
    }
}