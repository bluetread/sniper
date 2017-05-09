using Newtonsoft.Json;

namespace Sniper.Common
{
    /// <summary>
    /// Represents reference to downloaded message
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/MessageUids/meta">API documentation - MessageUid</a>
    /// </remarks>
    public class MessageUniqueId : Entity
    {

        [JsonProperty(Required = Required.Default)]
        public string MailLogin { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string MailServer { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string Uid { get; set; }
    }
}