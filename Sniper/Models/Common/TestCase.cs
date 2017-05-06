using Sniper.Application;
using Sniper.Contracts.Entities.Common;
using System;
using System.Collections.ObjectModel;
using static Sniper.CustomAttributes.CustomAttributes;
using static Sniper.TargetProcess.Common.Enumerations;

namespace Sniper.Common
{
    ///<summary>
    /// A set of steps to determine if a product functionality is working correctly. TestCase relates to User Story.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/TestCases/meta">API documentation - TestCase</a>
    /// </remarks>
    public class TestCase : General, IHasPriority, IHasTestPlans, IHasTestCaseRuns, IHasTestSteps, IHasUserStories
    {
        #region Required for Create

        [RequiredForCreate]
        public override string Name { get; set; }

        [RequiredForCreate(JsonProperties.Id)]
        public override Project Project { get; set; }

        #endregion

        public string LastFailureComment { get; set; }
        public DateTime? LastRunDate { get; set; }

        public TestCaseRunStatus LastRunStatus { get; set; }

        public Priority Priority { get; set; }

        public Collection<TestCaseRun> TestCaseRun { get; set; }
        public Collection<TestPlan> TestPlan { get; set; }
        public Collection<TestStep> TestStep { get; set; }
        public Collection<UserStory> UserStories { get; set; }
    }
}