using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasUserStories
    {
        Collection<UserStory> UserStories { get; set; }
    }
}