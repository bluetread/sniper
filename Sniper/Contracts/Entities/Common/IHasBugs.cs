using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasBugs
    {
        Collection<Bug> Bugs { get; }
    }
}