using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts
{
    public interface IHasWorkFlows
    {
        Collection<Workflow> Workflows { get; set; }
    }
}