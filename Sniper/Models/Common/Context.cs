using Newtonsoft.Json;
using Sniper.Contracts.Entities.Common;
using System.Collections.ObjectModel;

namespace Sniper.Common
{
    /// <summary>
    /// Context contains information about logged User, Culture, selected Projects and Processes.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Context/meta">API documentation - Context</a>
    /// </remarks>
    public class Context : Entity, IHasCustomFields
    {
        [JsonProperty(Required = Required.Default)]
        public string Acid { get; set; }

        [JsonProperty(Required = Required.Default)]
        public bool AnyProject { get; set; }

        [JsonProperty(Required = Required.Default)]
        public bool AnyTeam { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string Edition { get; set; }

        [JsonProperty(Required = Required.Default)]
        public bool IsFull { get; set; }

        [JsonProperty(Required = Required.Default)]
        public bool IsNoTeamIncluded { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string Version { get; set; }

        [JsonProperty(Required = Required.Default)]
        public AppContext AppContext { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Culture Culture { get; set; }

        [JsonProperty(Required = Required.Default)]
        public User LoggedUser { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<CustomField> CustomFields { get; set; }
    }
}