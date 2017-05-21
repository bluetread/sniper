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
    }
}