using Newtonsoft.Json;
using Sniper.Application;
using Sniper.Contracts;
using System;
using System.Collections.ObjectModel;

namespace Sniper.Common
{
    ///<summary>
    /// Spent/Remaining time for Assignable (Task, User Story, Bug, etc.).
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Times/meta">API documentation - Time</a>
    /// </remarks>

    public class Time : IHasId, IHasAssignable, IHasBug, IHasCreateDate, IHasCustomActivity,
        IHasDate, IHasDescription, IHasProject, IHasRequest, IHasRole, IHasTask, IHasTestPlan,
        IHasTestPlanRun, IHasUser, IHasUserStory, IHasWorkEffort, IHasCustomFields
    {
        public int Id { get; set; }
        public DateTime? CreateDate { get; set; }

        [JsonProperty(JsonProperties.Date)]
        public DateTime? EntryDate { get; set; }

        public string Description { get; set; }
        public bool IsEstimation { get; set; }
        public decimal Remain { get; set; }
        public decimal Spent { get; set; }

        public Assignable Assignable { get; set; }
        public Bug Bug { get; set; }
        public CustomActivity CustomActivity { get; set; }
        public Project Project { get; set; }
        public Request Request { get; set; }
        public Role Role { get; set; }
        public Task Task { get; set; }
        public TestPlan TestPlan { get; set; }
        public TestPlanRun TestPlanRun { get; set; }
        public User User { get; set; }
        public UserStory UserStory { get; set; }

        public Collection<CustomField> CustomFields { get; set; }
    }
}