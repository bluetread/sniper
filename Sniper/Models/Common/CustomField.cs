using Sniper.Contracts.Entities.Common;
using static Sniper.TargetProcess.Common.Enumerations;

namespace Sniper.Common
{
    ///<summary>
    /// Custom field is an entity extension which is declared on a process level.
    /// As a result entity can contain declared custom field values.
    /// Custom fields has following types: Text, DropDown, CheckBox, Url, Date, RichText, Number, Entity.
    /// See reference for more details.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/CustomFields/meta">API documentation - CustomField</a>
    /// </remarks>
    public class CustomField : Entity, IHasName, IHasEntityType, IHasProcess
    {
        public bool EnabledForFilter { get; set; }
        public string EntityFieldName { get; set; }
        public string Name { get; set; }
        public double NumericPriority { get; set; }
        public bool Required { get; set; }
        public string Value { get; set; }

        public CustomFieldConfig Config { get; set; }
        public EntityType EntityType { get; set; }
        public FieldType FieldType { get; set; }
        public Process Process { get; set; }
    }
}