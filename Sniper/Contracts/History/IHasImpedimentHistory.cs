using Sniper.History;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.History
{
    public interface IHasImpedimentHistory
    {
        Collection<ImpedimentSimpleHistory> History { get; set; }
    }
}