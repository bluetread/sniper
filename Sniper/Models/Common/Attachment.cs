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
        public string Description { get; set; }

        [JsonProperty(JsonProperties.Date)]
        public DateTime? EntryDate { get; set; }

        public string Name { get; set; }
        public string UniqueFileName { get; set; }

        public General General { get; set; }
        public Message Message { get; set; }
        public GeneralUser Owner { get; set; }
    }
}