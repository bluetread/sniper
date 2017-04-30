using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts
{
    public interface IHasMilestones
    {
        Collection<Milestone> Milestones { get; set; }
    }
}