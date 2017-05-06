using Sniper.Common;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasBug
    {
        Bug Bug { get; set; }
    }
}