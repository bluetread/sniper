using Newtonsoft.Json;
using Sniper.Contracts.Entities.Common;
using System;
using System.Collections.ObjectModel;

namespace Sniper.Common
{
    ///<summary>
    /// Group of people working on some projects.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Teams/meta">API documentation - Team</a>
    /// </remarks>
    public class Team : General, IHasActive, IHasCommonEntityCollections,
        IHasTeamIterations, IHasTeamMembers, IHasTeamProjects
    {
        [JsonProperty(Required = Required.Default)]
        public string Abbreviation { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string Icon { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Uri IconUri { get; set; }

        [JsonProperty(Required = Required.Default)]
        public bool IsActive { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Assignable> Assignables { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Bug> Bugs { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Epic> Epics { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Feature> Features { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Request> Requests { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Task> Tasks { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<TeamIteration> TeamIteration { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<TeamMember> TeamMember { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<TeamProject> TeamProjects { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<TestPlan> TestPlan { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<UserStory> UserStories { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<Workflow> SuggestedWorkflows { get; set; }
    }
}