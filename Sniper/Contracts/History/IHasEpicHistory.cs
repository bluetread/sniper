using Sniper.History;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.History
{
    public interface IHasEpicHistory
    {
        Collection<EpicSimpleHistory> History { get; set; }
    }
}