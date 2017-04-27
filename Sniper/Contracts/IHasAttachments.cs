using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts
{
    public interface IHasAttachments
    {
        Collection<Attachment> Attachments { get; set; }
    }
}
