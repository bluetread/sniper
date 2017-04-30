using Sniper.Common;

namespace Sniper.Contracts.History
{
    public interface IHasModifier
    {
        GeneralUser Modifier { get; set; }
    }
}