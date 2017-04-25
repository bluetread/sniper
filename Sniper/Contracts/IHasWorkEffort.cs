namespace Sniper.Contracts
{
    public interface IHasWorkEffort
    {
        decimal Remain { get; }
        decimal Spent { get; }
        bool IsEstimation { get; }
    }
}
