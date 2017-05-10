using Newtonsoft.Json;
using Sniper.Contracts.Entities.Common;
using System;
using System.Collections.ObjectModel;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    ///<summary>
    /// Group of people working on some projects.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Teams/meta">API documentation - Team</a>
    /// </remarks>
    [CanCreateReadUpdateDelete]
    public class Team : General, IHasActive, IHasCommonEntityCollections,
        IHasTeamIterations, IHasTeamMembers, IHasTeamProjects
    {
        [JsonProperty(Required = Required.Default)]
        public string Abbreviation { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string Icon { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Uri IconUri { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public bool IsActive { get; set; }

        #region Collections

        [JsonProperty(Required = Required.Default)]
        public Collection<Assignable> Assignables { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Bug> Bugs { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Epic> Epics { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Feature> Features { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Request> Requests { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Task> Tasks { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<TeamIteration> TeamIteration { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<TeamMember> TeamMember { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<TeamProject> TeamProjects { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<TestPlan> TestPlan { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<UserStory> UserStories { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Workflow> SuggestedWorkflows { get; internal set; }
        
        #endregion
    }
}