using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasProjects
    {
        Collection<Project> Projects { get; }
    }
}