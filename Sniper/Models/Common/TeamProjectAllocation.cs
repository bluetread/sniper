using Sniper.Contracts;

namespace Sniper.Common
{
    ///<summary>
    /// Team allocation to a Project

    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/TeamProjectAllocations/meta">API documentation - TeamProjectAllocation</a>
    /// </remarks>
    public class TeamProjectAllocation : ProjectAllocation, IHasTeamProject
    {
        public TeamProject TeamProject { get; set; }
    }
}