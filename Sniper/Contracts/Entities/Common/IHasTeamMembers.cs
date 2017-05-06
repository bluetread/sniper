using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasTeamMembers
    {
        Collection<TeamMember> TeamMember { get; set; }
    }
}