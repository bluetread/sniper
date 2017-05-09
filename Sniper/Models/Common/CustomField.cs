using Newtonsoft.Json;
using Sniper.Contracts.Entities.Common;
using Sniper.TargetProcess.Common;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    ///<summary>
    /// Custom field is an entity extension which is declared on a process level.
    /// As a result entity can contain declared custom field values.
    /// Custom fields has following types: Text, DropDown, CheckBox, Url, Date, RichText, Number, Entity.
    /// See reference for more details.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/CustomFields/meta">API documentation - CustomField</a>
    /// </remarks>
    public class CustomField : Entity, IHasName, IHasEntityType, IHasProcess
    {
        [RequiredForCreate]
        [JsonProperty(Required = Newtonsoft.Json.Required.DisallowNull)]
        public string Name { get; set; }

        [JsonProperty(Required = Newtonsoft.Json.Required.Default)]
        public bool EnabledForFilter { get; set; }

        [JsonProperty(Required = Newtonsoft.Json.Required.Default)]
        public string EntityFieldName { get; set; }

        [JsonProperty(Required = Newtonsoft.Json.Required.Default)]
        public double NumericPriority { get; set; }

        [JsonProperty(Required = Newtonsoft.Json.Required.Default)]
        public bool Required { get; set; }

        [JsonProperty(Required = Newtonsoft.Json.Required.Default)]
        public string Value { get; set; }

        [JsonProperty(Required = Newtonsoft.Json.Required.Default)]
        public CustomFieldConfig Config { get; set; }

        [RequiredForCreate]
        [JsonProperty(Required = Newtonsoft.Json.Required.DisallowNull)]
        public EntityType EntityType { get; set; }

        [JsonProperty(Required = Newtonsoft.Json.Required.Default)]
        public Enumerations.FieldType FieldType { get; set; }

        [JsonProperty(Required = Newtonsoft.Json.Required.Default)]
        public Process Process { get; set; }
    }
}