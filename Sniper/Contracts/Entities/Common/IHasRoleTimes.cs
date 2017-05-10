namespace Sniper.Contracts.Entities.Common
{
    public interface IHasRoleTimes
    {
        decimal RoleTimeRemain { get; set; }
        decimal RoleTimeSpent { get; set; }
    }
}