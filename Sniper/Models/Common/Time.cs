using Newtonsoft.Json;
using Sniper.Application;
using Sniper.Contracts.Entities.Common;
using System;
using System.Collections.ObjectModel;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    ///<summary>
    /// Spent/Remaining time for Assignable (Task, User Story, Bug, etc.).
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Times/meta">API documentation - Time</a>
    /// </remarks>
    [CanCreateReadUpdateDelete]
    public class Time : Entity, IHasAssignable, IHasBug, IHasCreateDate, IHasCustomActivity,
        IHasDate, IHasDescription, IHasProject, IHasRequest, IHasRole, IHasTask, IHasTestPlan,
        IHasTestPlanRun, IHasUser, IHasUserStory, IHasWorkEffort, IHasCustomFields
    {
        [JsonProperty(Required = Required.Default)]
        public DateTime? CreateDate { get; internal set; }

        //[RequiredForCreate] //TODO:check. Docs don't have this required, but I believe it is.
        [JsonProperty(Required = Required.Default)]
        public string Description { get; set; }


        [JsonProperty(JsonProperties.Date, Required = Required.Default)]
        public DateTime? EntryDate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public bool IsEstimation { get; set; }

        [JsonProperty(Required = Required.Default)]
        public decimal Remain { get; set; }

        [JsonProperty(Required = Required.Default)]
        public decimal Spent { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Assignable Assignable { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Bug Bug { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public CustomActivity CustomActivity { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Project Project { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Request Request { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Role Role { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Task Task { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public TestPlan TestPlan { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public TestPlanRun TestPlanRun { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public User User { get; set; }

        [JsonProperty(Required = Required.Default)]
        public UserStory UserStory { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<CustomField> CustomFields { get; internal set; }
    }
}