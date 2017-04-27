using Sniper.Http;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using static Sniper.WarningsErrors.MessageSuppression;

namespace Sniper
{
    internal static class StringExtensions
    {
        public static Uri FormatUri(this string pattern, params object[] args)
        {
            Ensure.ArgumentNotNullOrEmptyString(HttpKeys.Pattern, pattern);

            return new Uri(string.Format(CultureInfo.InvariantCulture, pattern, args), UriKind.Relative);
        }

        public static string UriEncode(this string input)
        {
            return WebUtility.UrlEncode(input);
        }

        public static string ToBase64String(this string input)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(input));
        }

        public static string FromBase64String(this string encoded)
        {
            var decodedBytes = Convert.FromBase64String(encoded);
            return Encoding.UTF8.GetString(decodedBytes, 0, decodedBytes.Length);
        }

        private static readonly Regex _optionalQueryStringRegex = new Regex("\\{\\?([^}]+)\\}");

        public static Uri ExpandUriTemplate(this string template, object values)
        {
            var optionalQueryStringMatch = _optionalQueryStringRegex.Match(template);
            if (optionalQueryStringMatch.Success)
            {
                var expansion = string.Empty;
                var parameters = optionalQueryStringMatch.Groups[1].Value.Split(',');

                foreach (var parameter in parameters)
                {
                    var parameterProperty = values.GetType().GetProperty(parameter);
                    if (parameterProperty != null)
                    {
                        expansion += string.IsNullOrWhiteSpace(expansion) ? "?" : "&";
                        expansion += parameter + "=" +
                            Uri.EscapeDataString("" + parameterProperty.GetValue(values, new object[0]));
                    }
                }
                template = _optionalQueryStringRegex.Replace(template, expansion);
            }
            return new Uri(template);
        }

        [SuppressMessage(Categories.Globalization, MessageAttributes.NormalizeStringsToUppercase)]
        public static string ToLowerCase(this string input)
        {
            Ensure.ArgumentNotNullOrEmptyString(nameof(input), input);
            return input.ToLowerInvariant();
        }

        [SuppressMessage(Categories.Globalization, MessageAttributes.NormalizeStringsToUppercase)]
        public static string ToRubyCase(this string propertyName)
        {
            Ensure.ArgumentNotNullOrEmptyString(nameof(propertyName), propertyName);
            return string.Join("_", propertyName.SplitUpperCase()).ToLowerInvariant();
        }

        public static string FromRubyCase(this string propertyName)
        {
            Ensure.ArgumentNotNullOrEmptyString(nameof(propertyName), propertyName);
            return string.Join(string.Empty, propertyName.Split('_')).ToCapitalizedInvariant();
        }

        public static string ToCapitalizedInvariant(this string value)
        {
            Ensure.ArgumentNotNullOrEmptyString(nameof(value), value);
            return string.Concat(value[0].ToString().ToUpperInvariant(), value.Substring(1));
        }

        private static IEnumerable<string> SplitUpperCase(this string source)
        {
            Ensure.ArgumentNotNullOrEmptyString(nameof(source), source);

            var wordStartIndex = 0;
            var letters = source.ToCharArray();
            var previousChar = char.MinValue;

            // Skip the first letter. we don't care what case it is.
            for (var i = 1; i < letters.Length; i++)
            {
                if (char.IsUpper(letters[i]) && !char.IsWhiteSpace(previousChar))
                {
                    //Grab everything before the current character.
                    yield return new string(letters, wordStartIndex, i - wordStartIndex);
                    wordStartIndex = i;
                }
                previousChar = letters[i];
            }

            //We need to have the last word.
            yield return new string(letters, wordStartIndex, letters.Length - wordStartIndex);
        }

        // the rule:
        // Username may only contain alphanumeric characters or single hyphens
        // and cannot begin or end with a hyphen
        private static readonly Regex _nameWithOwner = new Regex("[a-z0-9.-]{1,}/[a-z0-9.-_]{1,}",
            RegexOptions.Compiled | RegexOptions.IgnoreCase);

        internal static bool IsNameWithOwnerFormat(this string input)
        {
            return _nameWithOwner.IsMatch(input);
        }

        internal static IReadOnlyDictionary<string, string> GetHeaders(this WebHeaderCollection webHeaderCollection)
        {
            Ensure.ArgumentNotNull(nameof(webHeaderCollection), webHeaderCollection);
            var dict = webHeaderCollection.AllKeys.ToDictionary(λ => λ, λ => webHeaderCollection[λ]);
            return new ReadOnlyDictionary<string, string>(dict);
        }
    }
}