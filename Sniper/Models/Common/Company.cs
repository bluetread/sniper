using Newtonsoft.Json;
using Sniper.Contracts.Entities.Common;
using System.Collections.ObjectModel;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    ///<summary>
    /// Used to limit Requests visibility in Help Desk. Requesters from Company A will not see Requests from Company B.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Companies/meta">API documentation - Company</a>
    /// </remarks>
    [CanCreateReadUpdateDelete]
    public class Company : Entity, IHasDescription, IHasName, IHasUrl, IHasProjects, IHasRequesters
    {
        #region Required for Create

        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public string Name { get; set; }

        #endregion

        [JsonProperty(Required = Required.Default)]
        public string Description { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string Url { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Project> Projects { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Requester> Requesters { get; internal set; }
    }
}