using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts
{
    public interface IHasUserStories
    {
        Collection<UserStory> UserStories { get; set; }
    }
}
