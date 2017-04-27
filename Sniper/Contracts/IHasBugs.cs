using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts
{
    public interface IHasBugs
    {
        Collection<Bug> Bugs { get; set; }
    }
}
