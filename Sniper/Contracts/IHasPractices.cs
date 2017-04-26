using System.Collections.ObjectModel;
using Sniper.Common;

namespace Sniper.Contracts
{
    public interface IHasPractices
    {
        Collection<Practice> Practices { get; set; }
    }
}
