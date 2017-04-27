using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts
{
    public interface IHasAssignables
    {
        Collection<Assignable> Assignables { get; set; }
    }
}