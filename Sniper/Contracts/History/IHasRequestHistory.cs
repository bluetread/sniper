using Sniper.History;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.History
{
    public interface IHasRequestHistory
    {
        Collection<RequestSimpleHistory> History { get; set; }
    }
}
