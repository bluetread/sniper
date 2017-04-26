using System.Collections.ObjectModel;
using Sniper.Common;

namespace Sniper.Contracts
{
    public interface IHasTeamIterations
    {
        Collection<TeamIteration> TeamIteration { get; set; }
    }
}
