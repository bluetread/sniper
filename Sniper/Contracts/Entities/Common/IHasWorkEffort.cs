namespace Sniper.Contracts.Entities.Common
{
    public interface IHasWorkEffort
    {
        decimal Remain { get; set; }
        decimal Spent { get; set; }
        bool IsEstimation { get; set; }
    }
}