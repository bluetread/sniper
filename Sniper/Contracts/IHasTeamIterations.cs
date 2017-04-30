using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts
{
    public interface IHasTeamIterations
    {
        Collection<TeamIteration> TeamIteration { get; set; }
    }
}