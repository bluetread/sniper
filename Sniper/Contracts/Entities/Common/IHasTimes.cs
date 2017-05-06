using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasTimes
    {
        Collection<Time> Times { get; set; }
    }
}