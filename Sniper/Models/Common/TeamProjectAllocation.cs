using Newtonsoft.Json;
using Sniper.Application;
using Sniper.Contracts.Entities.Common;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    ///<summary>
    /// Team allocation to a Project

    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/TeamProjectAllocations/meta">API documentation - TeamProjectAllocation</a>
    /// </remarks>
    [CanCreateReadUpdateDelete]
    public class TeamProjectAllocation : ProjectAllocation, IHasTeamProject
    {
        #region Required for Create

        [RequiredForCreate(JsonProperties.Project, JsonProperties.Team)]
        [JsonProperty(Required = Required.DisallowNull)]
        public TeamProject TeamProject { get; set; }

        #endregion
    }
}