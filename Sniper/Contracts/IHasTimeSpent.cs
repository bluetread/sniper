namespace Sniper.Contracts
{
    public interface IHasTimeSpent
    {
        decimal TimeRemain { get; set; }
        decimal TimeSpent { get; set; }
    }
}