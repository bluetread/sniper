using Sniper.Contracts;
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
        public string Abbreviation { get; set; }
        public string Icon { get; set; }
        public Uri IconUri { get; set; }
        public bool IsActive { get; set; }

        public Collection<Assignable> Assignables { get; set; }
        public Collection<Bug> Bugs { get; set; }
        public Collection<Epic> Epics { get; set; }
        public Collection<Feature> Features { get; set; }
        public Collection<Request> Requests { get; set; }
        public Collection<Task> Tasks { get; set; }
        public Collection<TeamIteration> TeamIteration { get; set; }
        public Collection<TeamMember> TeamMember { get; set; }
        public Collection<TeamProject> TeamProjects { get; set; }
        public Collection<TestPlan> TestPlan { get; set; }
        public Collection<UserStory> UserStories { get; set; }
        public Collection<Workflow> SuggestedWorkflows { get; set; }
    }
}