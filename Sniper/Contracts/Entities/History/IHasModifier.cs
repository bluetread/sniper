using Sniper.Common;

namespace Sniper.Contracts.Entities.History
{
    public interface IHasModifier
    {
        GeneralUser Modifier { get; }
    }
}