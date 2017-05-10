using Sniper.Common;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasCustomActivity
    {
        CustomActivity CustomActivity { get; set; }
    }
}