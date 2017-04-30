using Sniper.Common;

namespace Sniper.Contracts
{
    public interface IHasTestStep
    {
        TestStep TestStep { get; set; }
    }
}