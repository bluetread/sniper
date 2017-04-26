using Sniper.Common;

namespace Sniper.Contracts
{
    public interface IHasOwner
    {
        GeneralUser Owner { get; set; }
    }
}
