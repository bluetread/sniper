using Sniper.History;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.Entities.History
{
    public interface IHasEpicHistory
    {
        Collection<EpicSimpleHistory> History { get; }
    }
}