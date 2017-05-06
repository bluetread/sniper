using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasAssignedTeams
    {
        Collection<TeamAssignment> AssignedTeams { get; set; }
    }
}