using Newtonsoft.Json;
using Sniper.Contracts.Entities.Common;
using static Sniper.TargetProcess.Common.Enumerations;

namespace Sniper.Common
{
    ///<summary>
    /// Represents a requester.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Requesters/meta">API documentation - Requester</a>
    /// </remarks>
    public class Requester : GeneralUser, IHasCompany
    {

        [JsonProperty(Required = Required.Default)]
        public string Notes { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string Phone { get; set; }
        
        [JsonProperty(Required = Required.Default)]
        public RequesterSourceType SourceType { get; set; }
        
        [JsonProperty(Required = Required.Default)]
        public Company Company { get; set; }
    }
}