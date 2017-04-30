using System.Collections.ObjectModel;
using Sniper.Common;

namespace Sniper.Contracts
{
    public interface IHasTimes
    {
        Collection<Time> Times { get; set; }
    }
}
