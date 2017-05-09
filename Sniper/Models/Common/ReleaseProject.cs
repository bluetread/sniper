using Newtonsoft.Json;
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
    public class ReleaseProject : Entity, IHasProject, IHasRelease
    {
        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public Project Project { get; set; }

        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public Release Release { get; set; }
    }
}