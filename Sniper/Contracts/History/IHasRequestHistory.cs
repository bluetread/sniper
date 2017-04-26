using System.Collections.ObjectModel;
using Sniper.History;

namespace Sniper.Contracts.History
{
    public interface IHasRequestHistory
    {
        Collection<RequestSimpleHistory> History { get; set; }
    }
}
