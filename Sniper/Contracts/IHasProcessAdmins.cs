using System.Collections.ObjectModel;
using Sniper.Common;

namespace Sniper.Contracts
{
    public interface IHasProcessAdmins
    {
        Collection<User> ProcessAdmins { get; set; }
    }
}
