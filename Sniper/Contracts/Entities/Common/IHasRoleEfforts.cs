using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasRoleEfforts
    {
        Collection<RoleEffort> RoleEfforts { get; }
    }
}