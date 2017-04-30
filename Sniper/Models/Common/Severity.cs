using Sniper.Contracts;

namespace Sniper.Common
{
    ///<summary>
    /// Severity (badness) of Bug. For example, Blocking, Critical, Small.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Severities/meta">API documentation - Severity</a>
    /// </remarks>
    public class Severity : IHasId, IHasName
    {
        public int Id { get; set; }
        public int Importance { get; set; }
        public bool IsDefault { get; set; }
        public string Name { get; set; }
    }
}