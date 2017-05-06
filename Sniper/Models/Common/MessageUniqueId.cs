using Sniper.Contracts.Entities.Common;

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
        public string MailLogin { get; set; }
        public string MailServer { get; set; }
        public string Uid { get; set; }
    }
}