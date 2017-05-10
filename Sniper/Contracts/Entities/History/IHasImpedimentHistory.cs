using Sniper.History;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.Entities.History
{
    public interface IHasImpedimentHistory
    {
        Collection<ImpedimentSimpleHistory> History { get; set; }
    }
}