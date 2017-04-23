using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using static Sniper.WarningsErrors.MessageSuppression;
using System.IO;
using System.Linq;
using Sniper.Http;
using Sniper.TargetProcess;
using System.Net;
using System.Text;

namespace Sniper
{
    public static class ApiSiteHelpers
    {
        public static string GetRouteByResourceName(string entityName)
        {
            Ensure.ArgumentNotNullOrEmptyString(nameof(entityName), entityName);

            return TargetProcessResources.ResourceRoutes.TryGetValue(entityName, out string result) ? result : null;
        }

        public static IApiResponse<string> GetSiteData(IApiSiteInfo apiSiteInfo, Http.ICredentials credentials)
        {
            return GetSiteData(apiSiteInfo, credentials, Encoding.UTF8);
        }

        public static IApiResponse<string> GetSiteData(IApiSiteInfo apiSiteInfo, Http.ICredentials credentials, Encoding encoding)
        {
            Ensure.ArgumentNotNull(nameof(apiSiteInfo), apiSiteInfo);
            Ensure.ArgumentNotNull(nameof(credentials), credentials);
            Ensure.ArgumentNotNull(nameof(encoding), encoding);
            Ensure.ArgumentNotNull(nameof(apiSiteInfo.Route), apiSiteInfo.Route);

            using (var client = new WebClient())
            {
                client.BaseAddress = apiSiteInfo.ApiUrl;
                client.Encoding = encoding;
                client.Credentials = new NetworkCredential(credentials.Login, credentials.Password);
                var result = client.DownloadString(Path.Combine(client.BaseAddress, "UserStories"));
                if (result.Length == 0) throw new InvalidDataException();

            }
            //TODO:
            return null;
        }

        [SuppressMessage(Categories.Globalization, MessageAttributes.SpecifyIFormatProvider)]
        public static string ToQueryString(this Dictionary<string, string> dictionary)
        {
            Ensure.ArgumentNotNull(nameof(dictionary), dictionary);
            var array = (dictionary.Keys.SelectMany(key => dictionary.Values, (key, value) => 
                $"{WebUtility.UrlEncode(key)}={WebUtility.UrlEncode(value)}")).ToArray();

            return "?" + string.Join("&", array);
        }

        public static Uri BuildUri(Collection<string> pathList, Dictionary<string, string> parameters)
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
            return new Uri(sb.ToString() + parameters.ToQueryString());
        }
    }
}
