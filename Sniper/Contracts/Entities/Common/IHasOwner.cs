using Sniper.Common;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasOwner
    {
        GeneralUser Owner { get; set; }
    }
}