using Sniper.Contracts;

namespace Sniper.Common
{
    ///<summary>
    /// Link between test plan run and test case run.
    /// In hierarchical test plan runs each test case run is linked to all parent test plan runs
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/TestRunItemHierarchyLinks/meta">API documentation - TestRunItemHierarchyLink</a>
    /// </remarks>
    public class TestRunItemHierarchyLink : IHasId, IHasTestCaseRun, IHasTestPlanRun
    {
        public int Id { get; set; }

        public TestCaseRun TestCaseRun { get; set; }
        public TestPlanRun TestPlanRun { get; set; }
    }
}