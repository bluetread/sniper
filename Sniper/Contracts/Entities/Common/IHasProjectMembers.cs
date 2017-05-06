using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasProjectMembers
    {
        Collection<ProjectMember> ProjectMembers { get; set; }
    }
}