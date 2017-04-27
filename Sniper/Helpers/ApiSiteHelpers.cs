using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Text;
using static Sniper.WarningsErrors.MessageSuppression;

namespace Sniper
{
    public static class ApiSiteHelpers
    {
        public static Dictionary<string, string> CombineDictionaries(Dictionary<string, string> source, KeyValuePair<string, string> overrideItem)
        {
            Ensure.ArgumentNotNullOrEmptyString(nameof(overrideItem.Key), overrideItem.Key);

            if (source == null) return new Dictionary<string, string>
            {
                {overrideItem.Key, overrideItem.Value}
            };

            source[overrideItem.Key] = overrideItem.Value;
            return source;
        }

        public static Dictionary<string, string> CombineDictionaries(Dictionary<string, string> source, Dictionary<string, string> overrides)
        {
            if (source == null && overrides == null) return new Dictionary<string, string>();
            if (source == null) return overrides;
            if (overrides == null) return source;
            foreach (var kvp in overrides)
            {
                CombineDictionaries(source, kvp);
            }
            return source;
        }

        [SuppressMessage(Categories.Globalization, MessageAttributes.SpecifyIFormatProvider)]
        public static string ToQueryString(this Dictionary<string, string> dictionary)
        {
            Ensure.ArgumentNotNull(nameof(dictionary), dictionary);
            if (dictionary.Count == 0) return string.Empty;
            var array = (dictionary.Select(kvp => $"{WebUtility.UrlEncode(kvp.Key)}={WebUtility.UrlEncode(kvp.Value)}")).ToArray();
            return "?" + string.Join("&", array);
        }

        [SuppressMessage(Categories.Design, MessageAttributes.UriReturnValuesShouldNotBeStrings)]
        public static string CombineUrlPaths(string path, string route)
        {
            Ensure.ArgumentNotNullOrEmptyString(nameof(path), path);
            Ensure.ArgumentNotNullOrEmptyString(nameof(route), route);

            var pathItem = path.EndsWith(@"/", StringComparison.CurrentCultureIgnoreCase) ? path.Substring(0, path.Length - 1) : path;
            pathItem = pathItem.StartsWith(@"/", StringComparison.CurrentCultureIgnoreCase) ? pathItem.Substring(1, pathItem.Length - 1) : pathItem;
            var routeItem = route.EndsWith(@"/", StringComparison.CurrentCultureIgnoreCase) ? route.Substring(0, route.Length - 1) : route;
            routeItem = routeItem.StartsWith(@"/", StringComparison.CurrentCultureIgnoreCase) ? routeItem.Substring(1, routeItem.Length - 1) : routeItem;

            return pathItem + @"/" + routeItem;
        }

        [SuppressMessage(Categories.Design, MessageAttributes.UriReturnValuesShouldNotBeStrings)]
        public static string BuildUriPath(Collection<string> pathList)
        {
            Ensure.ArgumentNotNull(nameof(pathList), pathList);

            var sb = new StringBuilder();
            for (var index = 0; index < pathList.Count; index++)
            {
                var pathItem = pathList[index];
                sb.Append(pathItem.EndsWith(@"/", StringComparison.CurrentCultureIgnoreCase) ? pathItem.Substring(0, pathItem.Length - 1) : pathItem);
                if (index < pathList.Count - 1)
                {
                    sb.Append(@"/");
                }
            }
            return sb.ToString();
        }

        public static Uri CombinePathAndQueryParameters(Collection<string> pathList, Dictionary<string, string> parameters)
        {
            Ensure.ArgumentNotNull(nameof(pathList), pathList);
            var path = BuildUriPath(pathList);
            return new Uri(path + parameters.ToQueryString());
        }
    }
}
