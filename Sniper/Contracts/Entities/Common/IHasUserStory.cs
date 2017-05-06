using Sniper.Common;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasUserStory
    {
        UserStory UserStory { get; set; }
    }
}