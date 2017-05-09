using Newtonsoft.Json;
using Sniper.Application;
using Sniper.Contracts.Entities.Common;
using Sniper.Contracts.Entities.History;
using Sniper.History;
using System.Collections.ObjectModel;
using static Sniper.CustomAttributes.CustomAttributes;

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
        #region Required for Create

        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public override string Name { get; set; }

        [RequiredForCreate(JsonProperties.Id)]
        [JsonProperty(Required = Required.DisallowNull)]
        public override Project Project { get; set; }

        #endregion

        [JsonProperty(Required = Required.Default)]
        public decimal InitialEstimate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Epic Epic { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Bug> Bugs { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<FeatureSimpleHistory> History { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<UserStory> UserStories { get; set; }
    }
}