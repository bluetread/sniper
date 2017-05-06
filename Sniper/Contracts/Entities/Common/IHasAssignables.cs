using System.Collections.ObjectModel;
using Sniper.Common;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasAssignables
    {
        Collection<Assignable> Assignables { get; set; }
    }
}