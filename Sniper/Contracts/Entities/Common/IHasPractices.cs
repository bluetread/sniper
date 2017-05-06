using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasPractices
    {
        Collection<Practice> Practices { get; set; }
    }
}