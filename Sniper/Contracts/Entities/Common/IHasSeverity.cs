using Sniper.Common;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasSeverity
    {
        Severity Severity { get; set; }
    }
}