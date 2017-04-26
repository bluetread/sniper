using Sniper.Common;

namespace Sniper.Contracts
{
    public interface IHasSeverity
    {
        Severity Severity { get; set; }
    }
}
