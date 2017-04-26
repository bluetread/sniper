namespace Sniper.Contracts
{
    public interface IHasLeadCycleTimes
    {
        double CycleTime { get; set; }
        double LeadTime { get; set; }
    }
}
