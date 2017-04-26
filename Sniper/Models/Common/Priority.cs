using Sniper.Contracts;

namespace Sniper.Common
{
    /// <summary>
    /// Priority of User Story, Bug or Feature. Examples: Must Have, Nice to Have.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Priorities/meta">API documentation - Priority</a>
    /// </remarks>
    public class Priority : IHasId, IHasName, IHasEntityType
    {
        public int Id { get; set; }
        public int Importance { get; set; }
        public bool IsDefault { get; set; }
        public string Name { get; set; }
        public EntityType EntityType { get; set; }
    }
}
