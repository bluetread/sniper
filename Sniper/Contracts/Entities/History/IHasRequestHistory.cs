using Sniper.History;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.Entities.History
{
    public interface IHasRequestHistory
    {
        Collection<RequestSimpleHistory> History { get; }
    }
}