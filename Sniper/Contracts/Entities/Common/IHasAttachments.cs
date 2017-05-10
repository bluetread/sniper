using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasAttachments
    {
        Collection<Attachment> Attachments { get; }
    }
}