using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasMessages
    {
        Collection<Message> Messages { get; set; }
    }
}