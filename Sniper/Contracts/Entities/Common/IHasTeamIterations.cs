using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasTeamIterations
    {
        Collection<TeamIteration> TeamIteration { get; set; }
    }
}