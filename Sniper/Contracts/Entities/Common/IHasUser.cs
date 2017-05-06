using Sniper.Common;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasUser
    {
        User User { get; set; }
    }
}