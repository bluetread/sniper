using Sniper.Common;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasResponsibleTeam
    {
        TeamAssignment ResponsibleTeam { get; }
    }
}