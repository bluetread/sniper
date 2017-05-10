namespace Sniper.Contracts.Entities.Common
{
    public interface IHasEffort
    {
        decimal Effort { get; }
        decimal EffortCompleted { get; }
        decimal EffortToDo { get; }
    }
}