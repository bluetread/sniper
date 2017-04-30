using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts
{
    public interface IHasProcesses
    {
        Collection<Process> Processes { get; set; }
    }
}
