using Newtonsoft.Json;
using Sniper.Application;
using Sniper.Contracts.Entities.Common;
using static Sniper.CustomAttributes.CustomAttributes;
namespace Sniper.Common
{
    ///<summary>
    /// Project assigned to a release
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/ReleaseProjects/meta">API documentation - ReleaseProject</a>
    /// </remarks>
    [CanCreateReadUpdateDelete]
    public class ReleaseProject : Entity, IHasProject, IHasRelease
    {
        [RequiredForCreate(JsonProperties.Name, JsonProperties.EntityState)]
        [JsonProperty(Required = Required.DisallowNull)]
        public Project Project { get; set; }

        [RequiredForCreate(JsonProperties.Name, JsonProperties.StartDate, JsonProperties.EndDate)]
        [JsonProperty(Required = Required.DisallowNull)]
        public Release Release { get; set; }
    }
}