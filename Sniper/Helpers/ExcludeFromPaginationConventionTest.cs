using System;

namespace Sniper
{
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class ExcludeFromPaginationConventionTestAttribute : Attribute
    {
    }
}
