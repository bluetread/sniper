using System.Collections.ObjectModel;
using Sniper.Common;

namespace Sniper.Contracts
{
    public interface IHasUserStories
    {
        Collection<UserStory> UserStories { get; set; }
    }
}
