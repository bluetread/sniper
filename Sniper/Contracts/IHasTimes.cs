using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts
{
    public interface IHasTimes
    {
        Collection<Time> Times { get; set; }
    }
}