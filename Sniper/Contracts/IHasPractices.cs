using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts
{
    public interface IHasPractices
    {
        Collection<Practice> Practices { get; set; }
    }
}