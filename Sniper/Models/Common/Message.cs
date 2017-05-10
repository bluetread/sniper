using Newtonsoft.Json;
using Sniper.Contracts.Entities.Common;
using System;
using System.Collections.ObjectModel;
using static Sniper.TargetProcess.Common.Enumerations;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    /// <summary>
    /// Email message from email integration
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Messages/meta">API documentation - Message</a>
    /// </remarks>
    [CanCreateReadUpdateDelete]
    public class Message : Entity, IHasCreateDate
    {
        [JsonProperty(Required = Required.Default)]
        public string Body { get; set; }

        [JsonProperty(Required = Required.Default)]
        public DateTime? CreateDate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public bool IsProcessed { get; set; }

        [JsonProperty(Required = Required.Default)]
        public bool IsRead { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string Recipients { get; set; }

        [JsonProperty(Required = Required.Default)]
        public DateTime? SendDate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string Subject { get; set; }

        [JsonProperty(Required = Required.Default)]
        public ContentType ContentType { get; set; }

        [JsonProperty(Required = Required.Default)]
        public MessageType MessageType { get; set; }

        [JsonProperty(Required = Required.Default)]
        public GeneralUser From { get; set; }

        [JsonProperty(Required = Required.Default)]
        public GeneralUser To { get; set; }

        [JsonProperty(Required = Required.Default)]
        public MessageUniqueId MessageUid { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Attachment> Attachments { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<General> Generals { get; internal set; }
    }
}