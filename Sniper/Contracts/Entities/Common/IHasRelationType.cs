using Sniper.Common;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasRelationType
    {
        RelationType RelationType { get; set; }
    }
}