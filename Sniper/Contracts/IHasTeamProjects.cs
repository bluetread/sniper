using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts
{
    public interface IHasTeamProjects
    {
        Collection<TeamProject> TeamProjects { get; set; }
    }
}