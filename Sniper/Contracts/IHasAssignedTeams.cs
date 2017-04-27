using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts
{
    public interface IHasAssignedTeams
    {
        Collection<TeamAssignment> AssignedTeams { get; set; }
    }
}
