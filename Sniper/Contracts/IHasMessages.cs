using System.Collections.ObjectModel;
using Sniper.Common;

namespace Sniper.Contracts
{
    public interface IHasMessages
    {
        Collection<Message> Messages { get; set; }
    }
}
