using Sniper.Contracts;

namespace Sniper.Common
{
    /// <summary>
    /// Represents reference to downloaded message
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/MessageUids/meta">API documentation - MessageUid</a>
    /// </remarks>
    public class MessageUniqueId : IHasId
    {
        public int Id { get; set; }
        public string MailLogin { get; set; }
        public string MailServer { get; set; }
        public string Uid { get; set; }

    }
}
