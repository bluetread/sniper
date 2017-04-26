using System.Collections.ObjectModel;
using Sniper.Common;

namespace Sniper.Contracts
{
    public interface IHasImpediments
    {
        Collection<Impediment> Impediments { get; set; }
    }
}
