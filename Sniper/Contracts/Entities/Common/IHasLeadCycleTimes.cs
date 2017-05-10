namespace Sniper.Contracts.Entities.Common
{
    public interface IHasLeadCycleTimes
    {
        double CycleTime { get; }
        double LeadTime { get; }
    }
}