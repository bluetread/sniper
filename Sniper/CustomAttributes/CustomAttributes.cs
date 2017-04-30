using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Sniper.CustomAttributes
{
    public static class CustomAttributes
    {
        public abstract class CrudBaseAttribute : Attribute
        {
            public bool RequiresAdminRights { get; set; } = false;
        }

        public class CanCreateAttribute : CrudBaseAttribute { }
        public class CanDeleteAttribute : CrudBaseAttribute { }
        public class CanReadAttribute : CrudBaseAttribute { }
        public class CanUpdateAttribute : CrudBaseAttribute { }

        public class RequiredForCreateAttribute : Attribute
        {
            public RequiredForCreateAttribute(params string[] values)
            {
                RequiredPropertyNames = values.ListToReadOnlyCollection();
            }

            public IReadOnlyCollection<string> RequiredPropertyNames { get; set; }
        }
    }
}
