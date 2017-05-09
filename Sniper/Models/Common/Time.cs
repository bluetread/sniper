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

    public class Time : Entity, IHasAssignable, IHasBug, IHasCreateDate, IHasCustomActivity,
        IHasDate, IHasDescription, IHasProject, IHasRequest, IHasRole, IHasTask, IHasTestPlan,
        IHasTestPlanRun, IHasUser, IHasUserStory, IHasWorkEffort, IHasCustomFields
    {

        #region Required for Create

        [RequiredForCreate] //TODO:check. Docs don't have this required, but I believe it is.
        [JsonProperty(Required = Required.DisallowNull)]
        public string Description { get; set; }

        [RequiredForCreate(JsonProperties.Id)]
        [JsonProperty(Required = Required.DisallowNull)]
        public Project Project { get; set; }

        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public User User { get; set; }

        #endregion

        [JsonProperty(Required = Required.Default)]
        public DateTime? CreateDate { get; set; }

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
        public Bug Bug { get; set; }

        [JsonProperty(Required = Required.Default)]
        public CustomActivity CustomActivity { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Request Request { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Role Role { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Task Task { get; set; }

        [JsonProperty(Required = Required.Default)]
        public TestPlan TestPlan { get; set; }

        [JsonProperty(Required = Required.Default)]
        public TestPlanRun TestPlanRun { get; set; }

        [JsonProperty(Required = Required.Default)]
        public UserStory UserStory { get; set; }

        [JsonProperty(Required = Required.Default)]
        public Collection<CustomField> CustomFields { get; set; }
    }
}