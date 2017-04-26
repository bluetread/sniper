using System.Collections.ObjectModel;
using Sniper.History;

namespace Sniper.Contracts.History
{
    public interface IHasEpicHistory
    {
        Collection<EpicSimpleHistory> History { get; set; }
    }
}
