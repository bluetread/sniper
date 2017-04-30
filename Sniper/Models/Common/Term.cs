using Sniper.Contracts;

namespace Sniper.Common
{
    ///<summary>
    /// Beta version: Term in Process. Like Bug, User Story, Feature, etc.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Terms/meta">API documentation - Term</a>
    /// </remarks>
    public class Term : IHasId, IHasProcess, IHasEntityType
    {
        public int Id { get; set; }
        public string WordKey { get; set; }
        public string Value { get; set; }
        public Process Process { get; set; }
        public EntityType EntityType { get; set; }
    }
}
