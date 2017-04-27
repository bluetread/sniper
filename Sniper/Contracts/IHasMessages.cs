using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts
{
    public interface IHasMessages
    {
        Collection<Message> Messages { get; set; }
    }
}
