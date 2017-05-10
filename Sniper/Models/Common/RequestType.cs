using Newtonsoft.Json;
using Sniper.Contracts.Entities.Common;
using System.Collections.ObjectModel;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    ///<summary>
    /// Type of request (Idea, Issue or Question).
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/RequestTypes/meta">API documentation - RequestType</a>
    /// </remarks>
    [CanCreateReadUpdateDelete]
    public class RequestType : Entity, IHasName, IHasRequests
    {
        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public string Icon { get; set; }

        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public string Name { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Request> Requests { get; internal set; }
    }
}