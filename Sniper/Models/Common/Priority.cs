using Sniper.Application;
using Sniper.Contracts.Entities.Common;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    /// <summary>
    /// Priority of User Story, Bug or Feature. Examples: Must Have, Nice to Have.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/Priorities/meta">API documentation - Priority</a>
    /// </remarks>
    public class Priority : Entity, IHasName, IHasEntityType
    {
        public int Importance { get; set; }
        public bool IsDefault { get; set; }
        
        #region Required for Create

        [RequiredForCreate]
        public string Name { get; set; }

        [RequiredForCreate(JsonProperties.Id)]
        public EntityType EntityType { get; set; }

        #endregion
    }
}