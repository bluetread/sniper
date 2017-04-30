namespace Sniper.Contracts
{
    public interface IHasRoleTimes
    {
        decimal RoleTimeRemain { get; set; }
        decimal RoleTimeSpent { get; set; }
    }
}