namespace Sniper.Common
{
    ///<summary>
    /// User allocation to a Project
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/UserProjectAllocations/meta">API documentation - UserProjectAllocation</a>
    /// </remarks>
    public class UserProjectAllocation : ProjectAllocation
    {
        public ProjectMember ProjectMember { get; set; }
    }
}