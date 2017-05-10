using Sniper.Common;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasTestStep
    {
        TestStep TestStep { get; set; }
    }
}