using Sniper.Common;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasRole
    {
        Role Role { get; set; }
    }
}