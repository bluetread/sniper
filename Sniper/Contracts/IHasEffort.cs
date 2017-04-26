namespace Sniper.Contracts
{
    public interface IHasEffort
    {
        decimal Effort { get; set; }
        decimal EffortCompleted { get; set; }
        decimal EffortToDo { get; set; }
    }
}
