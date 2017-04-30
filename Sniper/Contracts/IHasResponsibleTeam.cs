using Sniper.Common;

namespace Sniper.Contracts
{
    public interface IHasResponsibleTeam
    {
        TeamAssignment ResponsibleTeam { get; set; }
    }
}