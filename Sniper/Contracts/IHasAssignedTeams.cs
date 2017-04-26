using System.Collections.ObjectModel;
using Sniper.Common;

namespace Sniper.Contracts
{
    public interface IHasAssignedTeams
    {
        Collection<TeamAssignment> AssignedTeams { get; set; }
    }
}
