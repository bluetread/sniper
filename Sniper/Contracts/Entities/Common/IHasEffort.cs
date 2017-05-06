namespace Sniper.Contracts.Entities.Common
{
    public interface IHasEffort
    {
        decimal Effort { get; set; }
        decimal EffortCompleted { get; set; }
        decimal EffortToDo { get; set; }
    }
}