using Sniper.Contracts;
using System.Collections.ObjectModel;

namespace Sniper.Common
{
    /// <summary>
    /// A single iteration results in an increment(s) of product functionality.
    /// Iteration should relate to a Release.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Iterations/meta">API documentation - Iteration</a>
    /// </remarks>
    public class Iteration : IterationBase, IHasRelease, IHasBuilds, IHasRequests
    {
        public Release Release { get; set; }

        public Collection<Build> Builds { get; set; }
        public Collection<Request> Requests { get; set; }
    }
}