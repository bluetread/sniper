using Sniper.Application;
using Sniper.Contracts.Entities.Common;
using System;
using System.Collections.ObjectModel;
using static Sniper.CustomAttributes.CustomAttributes;
using static Sniper.TargetProcess.Common.Enumerations;

namespace Sniper.Common
{
    ///<summary>
    /// A single Test Case Run. TestCase can be run many times.
    /// It is impossible to create a Test Case Run, instead Add Test Case to Test Plan to create a Test Case Run
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/TestCaseRuns/meta">API documentation - TestCaseRun</a>
    /// </remarks>
    public class TestCaseRun : Entity, IHasName, IHasDescription, IHasTestPlanRun, IHasTestCase,
        IHasEntityType, IHasPriority, IHasTestStepRuns, IHasBugs, IHasTestPlanRunLinks
    {
        public string Comment { get; set; }
        public string Description { get; set; }
        public DateTime EndRunDate { get; set; }
        public string Name { get; set; }
        public DateTime StartRunDate { get; set; }
        public TestCaseRunStatus Status { get; set; }
        public string Steps { get; set; }
        public string Success { get; set; }

        public EntityType EntityType { get; set; }
        public User LastExecutor { get; set; }
        public Priority Priority { get; set; }
        public TestPlanRun RootTestPlanRun { get; set; }
        public TestCase TestCase { get; set; }

        #region Required for Create

        [RequiredForCreate(JsonProperties.Id)]
        public TestPlanRun TestPlanRun { get; set; }

        #endregion
        

        public Collection<TestStepRun> TestStepRuns { get; set; }
        public Collection<Bug> Bugs { get; set; }
        public Collection<TestRunItemHierarchyLink> TestPlanRunLinks { get; set; }
    }
}