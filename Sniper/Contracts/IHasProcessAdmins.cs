using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts
{
    public interface IHasProcessAdmins
    {
        Collection<User> ProcessAdmins { get; set; }
    }
}
