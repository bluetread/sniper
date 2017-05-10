using Newtonsoft.Json;
using Sniper.Application;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    ///<summary>
    /// User allocation to a Project
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/UserProjectAllocations/meta">API documentation - UserProjectAllocation</a>
    /// </remarks>
    [CanCreateReadUpdateDelete]
    public class UserProjectAllocation : ProjectAllocation
    {
        #region Required for Create

        [RequiredForCreate(JsonProperties.Allocation, JsonProperties.Project, JsonProperties.Role, JsonProperties.User)]
        [JsonProperty(Required = Required.DisallowNull)]
        public ProjectMember ProjectMember { get; set; }

        #endregion
    }
}