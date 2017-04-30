using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts
{
    public interface IHasProjects
    {
        Collection<Project> Projects { get; set; }
    }
}