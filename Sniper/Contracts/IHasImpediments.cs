using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts
{
    public interface IHasImpediments
    {
        Collection<Impediment> Impediments { get; set; }
    }
}