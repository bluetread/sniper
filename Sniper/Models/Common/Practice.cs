using Newtonsoft.Json;
using Sniper.Contracts.Entities.Common;
using System.Collections.ObjectModel;
using static Sniper.CustomAttributes.CustomAttributes;
namespace Sniper.Common
{
    ///<summary>
    ///
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Practices/meta">API documentation - Practice</a>
    /// </remarks>
    [CannotCreateReadUpdateDelete]
    public class Practice : Entity, IHasName, IHasDescription, IHasProcesses
    {
        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public string DisplayName { get; set; }

        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public string Name { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string Description { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Process> Processes { get; internal set; }
    }
}