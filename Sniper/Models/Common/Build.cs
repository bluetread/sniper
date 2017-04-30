using Sniper.Contracts;
using System;
using System.Collections.ObjectModel;

namespace Sniper.Common
{
    ///<summary>
    /// Build in a project. Bugs and source code Revisions can be assigned to Build.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Builds/meta">API documentation - Build</a>
    /// </remarks>
    public class Build : General, IHasBugs, IHasTestPlanRuns
    {
        public DateTime BuildDate { get; set; }
        public Iteration Iteration { get; set; }
        public Release Release { get; set; }

        public Collection<Bug> Bugs { get; set; }
        public Collection<TestPlanRun> TestPlanRuns { get; set; }
    }
}