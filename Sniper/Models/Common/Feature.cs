using Sniper.Contracts;
using Sniper.Contracts.History;
using Sniper.History;
using System.Collections.ObjectModel;

namespace Sniper.Common
{
    ///<summary>
    /// A high-level requirement which contains user stories. Can be assigned to Release. Can't be assigned to Iteration.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Features/meta">API documentation - Feature</a>
    /// </remarks>
    public class Feature : Assignable, IHasInitialEstimate, IHasEpic,
        IHasBugs, IHasFeatureHistory, IHasUserStories
    {
        public decimal InitialEstimate { get; set; }

        public Epic Epic { get; set; }

        public Collection<Bug> Bugs { get; set; }
        public Collection<FeatureSimpleHistory> History { get; set; }
        public Collection<UserStory> UserStories { get; set; }
    }
}