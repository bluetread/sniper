using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasWorkFlows
    {
        Collection<Workflow> Workflows { get; }
    }
}