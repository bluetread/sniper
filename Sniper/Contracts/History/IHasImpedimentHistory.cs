using System.Collections.ObjectModel;
using Sniper.History;

namespace Sniper.Contracts.History
{
    public interface IHasImpedimentHistory
    {
       Collection<ImpedimentSimpleHistory> History { get; set; }
    }
}
