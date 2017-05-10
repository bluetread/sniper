using Newtonsoft.Json;
using Sniper.Contracts.Entities.Common;
using System.Collections.ObjectModel;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    /// <summary>
    /// Context contains information about logged User, Culture, selected Projects and Processes.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Context/meta">API documentation - Context</a>
    /// </remarks>
    [CanCreateReadUpdateDelete]

    public class Context : Entity, IHasCustomFields
    {
        [JsonProperty(Required = Required.Default)]
        public string Acid { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public bool AnyProject { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public bool AnyTeam { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public string Edition { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public bool IsFull { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public bool IsNoTeamIncluded { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public string Version { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public AppContext AppContext { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Culture Culture { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public User LoggedUser { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<CustomField> CustomFields { get; internal set; }
    }
}