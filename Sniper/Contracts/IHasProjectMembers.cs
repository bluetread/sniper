using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts
{
    public interface IHasProjectMembers
    {
        Collection<ProjectMember> ProjectMembers { get; set; }
    }
}