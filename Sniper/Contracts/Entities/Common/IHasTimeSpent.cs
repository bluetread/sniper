namespace Sniper.Contracts.Entities.Common
{
    public interface IHasTimeSpent
    {
        decimal TimeRemain { get; set; }
        decimal TimeSpent { get; set; }
    }
}