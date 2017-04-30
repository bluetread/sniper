namespace Sniper.Contracts
{
    public interface IHasWorkEffort
    {
        decimal Remain { get; set; }
        decimal Spent { get; set; }
        bool IsEstimation { get; set; }
    }
}