using Newtonsoft.Json;
using Sniper.Contracts.Entities.Common;
using System;
using static Sniper.TargetProcess.Common.Enumerations;

namespace Sniper.Common
{
    /// <summary>
    /// Email message from email integration
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Messages/meta">API documentation - Message</a>
    /// </remarks>
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
    }
}