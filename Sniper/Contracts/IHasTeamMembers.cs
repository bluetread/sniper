using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts
{
    public interface IHasTeamMembers
    {
        Collection<TeamMember> TeamMember { get; set; }
    }
}