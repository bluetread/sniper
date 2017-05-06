using System;
using System.Collections.Generic;

namespace Sniper.CustomAttributes
{
    public static class CustomAttributes
    {
        public abstract class CrudBaseAttribute : Attribute
        {
            public bool CanCreate { get; set; }
            public bool CanDelete { get; set; }
            public bool CanRead { get; set; } 
            public bool CanUpdate { get; set; }
            public bool RequiresAdminRights { get; set; } 
        }

        public class CanCreateAttribute : CrudBaseAttribute
        {
            public CanCreateAttribute() { CanCreate = true; }
        }

        public class CanDeleteAttribute : CrudBaseAttribute
        {
            public CanDeleteAttribute() { CanDelete = true; }
        }

        public class CanReadAttribute : CrudBaseAttribute
        {
            public CanReadAttribute() { CanRead = true; }
        }

        public class CanUpdateAttribute : CrudBaseAttribute
        {
            public CanUpdateAttribute() { CanUpdate = true; }
        }

        public class CanCreateReadUpdateDeleteAttribute : CrudBaseAttribute
        {
            public CanCreateReadUpdateDeleteAttribute()
            {
                CanCreate = true;
                CanDelete = true;
                CanRead = true;
                CanUpdate = true;
            }
        }

        public class CannotCreateReadUpdateDeleteAttribute : CrudBaseAttribute { }

        public class RequiredForCreateAttribute : Attribute
        {
            public bool IsEnabled { get; set; } = true;
            public IReadOnlyCollection<string> RequiredPropertyNames { get; set; }

            public RequiredForCreateAttribute() {}

            public RequiredForCreateAttribute(bool enabled)
            {
                IsEnabled = enabled;
            }

            public RequiredForCreateAttribute(params string[] values) : this(true)
            {
                RequiredPropertyNames = values.ListToReadOnlyCollection();
            }

            public RequiredForCreateAttribute(bool enabled, params string[] values) : this(values)
            {
                IsEnabled = enabled;
            }
        }
    }
}
