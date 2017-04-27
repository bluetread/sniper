using Sniper.Contracts;
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
    public class Message : IHasId, IHasCreateDate
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool IsProcessed { get; set; }
        public bool IsRead { get; set; }
        public string Recipients { get; set; }
        public DateTime? SendDate { get; set; }
        public string Subject { get; set; }

        public ContentType ContentType { get; set; }
        public MessageType MessageType { get; set; }
    }
}
