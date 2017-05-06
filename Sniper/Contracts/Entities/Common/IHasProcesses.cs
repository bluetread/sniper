using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasProcesses
    {
        Collection<Process> Processes { get; set; }
    }
}