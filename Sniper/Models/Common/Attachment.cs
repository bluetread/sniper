using Newtonsoft.Json;
using Sniper.Application;
using Sniper.Contracts.Entities.Common;
using System;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    ///<summary>
    /// A file (image, archive, whatever) attached to Entity.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Attachments/meta">API documentation - Attachment</a>
    /// </remarks>
    [CannotCreateReadUpdateDelete]
    public class Attachment : Entity, IHasDescription, IHasDate, IHasGeneral, IHasMessage, IHasName, IHasOwner
    {
        [JsonProperty(Required = Required.Default)]
        public string Description { get; set; }

        [JsonProperty(JsonProperties.Date, Required = Required.Default)]
        public DateTime? EntryDate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string Name { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string UniqueFileName { get; set; }

        [JsonProperty(Required = Required.Default)]
        public General General { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Message Message { get; set; }

        [JsonProperty(Required = Required.Default)]
        public GeneralUser Owner { get; set; }
    }
}