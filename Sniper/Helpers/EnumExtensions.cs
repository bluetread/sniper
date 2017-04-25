using System;
using System.Diagnostics.CodeAnalysis;
using static Sniper.WarningsErrors.MessageSuppression;

namespace Sniper
{
    internal static class EnumExtensions
    {
        [SuppressMessage(Categories.Globalization, MessageAttributes.NormalizeStringsToUppercase)]
        internal static string ToLowerCase(this Enum value)
        {
            Ensure.ArgumentNotNull(nameof(value), value);
            return value.ToString().ToLowerCase();
        }

        //internal static string ToParameter(this Enum prop)
        //{
        //    if (prop == null) return null;

        //    var propString = prop.ToString();
        //    var member = prop.GetType().GetMember(propString).FirstOrDefault();
        //    if (member == null) return null;

        //    var attribute = member.GetCustomAttributes(typeof(ParameterAttribute), false)
        //        .Cast<ParameterAttribute>()
        //        .FirstOrDefault();

        //    return attribute != null ? attribute.Value : propString.ToLowerInvariant();
        //}
    }
}
