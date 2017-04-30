using Sniper.Contracts;
using Sniper.Contracts.History;
using Sniper.History;
using System.Collections.ObjectModel;

namespace Sniper.Common
{
    ///<summary>
    /// Bug or defect (error, flaw, mistake, failure or fault in a computer program). Can relate to User Story. Can be assigned to Release and Iteration.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Bugs/meta">API documentation - Bug</a>
    /// </remarks>
    public class Bug : Assignable, IHasBuild, IHasFeature, IHasSeverity, IHasUserStory,
        IHasBugHistory, IHasTestCaseRuns, IHasTestPlanRuns
    {
        public Build Build { get; set; }
        public Feature Feature { get; set; }
        public Severity Severity { get; set; }
        public UserStory UserStory { get; set; }
        public Collection<BugSimpleHistory> History { get; set; }
        public Collection<TestCaseRun> TestCaseRun { get; set; }
        public Collection<TestPlanRun> TestPlanRuns { get; set; }
    }
}