using Sniper.Common;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasMessage
    {
        Message Message { get; set; }
    }
}