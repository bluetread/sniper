namespace Sniper.Contracts.Entities.Common
{
    public interface IHasLeadCycleTimes
    {
        double CycleTime { get; set; }
        double LeadTime { get; set; }
    }
}