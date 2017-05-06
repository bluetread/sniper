using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasMilestones
    {
        Collection<Milestone> Milestones { get; set; }
    }
}