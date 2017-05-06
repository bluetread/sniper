using Sniper.Contracts.Entities.Common;
using System.Collections.ObjectModel;
using static Sniper.CustomAttributes.CustomAttributes;
using static Sniper.TargetProcess.Common.Enumerations;

namespace Sniper.Common
{
    ///<summary>
    /// Type of Entity. For example: Bug, TestCase, Project.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/EntityTypes/meta">API documentation - EntityType</a>
    /// </remarks>
    [CannotCreateReadUpdateDelete]
    public class EntityType : Entity, IHasName, IAssignable, IExtendable
    {
        private CustomFieldScope CustomFieldScope { get; set; }
        public bool IsAssignable { get; set; }
        public bool IsExtendable { get; set; }
        public bool IsSearchable { get; set; }
        public bool IsUnitInHourOnly { get; set; }
        public string Name { get; set; }
        public Collection<EntityState> EntityStates { get; set; }
    }
}