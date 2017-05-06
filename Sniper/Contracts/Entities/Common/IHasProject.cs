using Sniper.Common;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasProject
    {
        Project Project { get; set; }
    }
}