namespace Sniper.Contracts.Entities.Common
{
    public interface IHasTimeSpent
    {
        decimal TimeRemain { get; }
        decimal TimeSpent { get; }
    }
}