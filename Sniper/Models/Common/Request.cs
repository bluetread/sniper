using Sniper.Application;
using Sniper.Contracts.Entities.History;
using Sniper.History;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using static Sniper.CustomAttributes.CustomAttributes;
using static Sniper.TargetProcess.Common.Enumerations;

namespace Sniper.Common
{
    ///<summary>
    /// Request can represent Idea, Issue or Question from users. Bugs, User Stories and Features can be linked to Requests.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Requests/meta">API documentation - Request</a>
    /// </remarks>
    [CanCreateReadUpdateDelete]
    public class Request : Assignable, IHasRequestHistory
    {
        #region Required for Create

        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public override string Name { get; set; }

        [RequiredForCreate(JsonProperties.Name)]
        [JsonProperty(Required = Required.DisallowNull)]
        public override EntityState EntityState { get; set; }

        [RequiredForCreate(JsonProperties.Name, JsonProperties.EntityState)]
        [JsonProperty(Required = Required.DisallowNull)]
        public override Project Project { get; set; }

        #endregion

        [JsonProperty(Required = Required.Default)]
        public bool IsPrivate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public bool IsReplied { get; set; }

        [JsonProperty(Required = Required.Default)]
        public int VotesCount { get; internal set; }
        
        [JsonProperty(Required = Required.Default)]
        public RequestSource SourceType { get; set; }

        [JsonProperty(Required = Required.Default)]
        public RequestType RequestType { get; set; }
        
        [JsonProperty(Required = Required.Default)]
        public Collection<GeneralUser> Requesters { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<RequestSimpleHistory> History { get; internal set; }
    }
}