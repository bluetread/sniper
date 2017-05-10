using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasImpediments
    {
        Collection<Impediment> Impediments { get; }
    }
}