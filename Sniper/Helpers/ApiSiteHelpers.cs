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
      

        //public static IApiResponse<string> GetSiteData(IAuthenticationHandler authenticationHandler)
        //{
        //    Ensure.ArgumentNotNull(nameof(authenticationHandler), authenticationHandler);
        //    Ensure.ArgumentNotNull(nameof(authenticationHandler.SiteInfo), authenticationHandler.SiteInfo);
        //    Ensure.ArgumentNotNull(nameof(authenticationHandler.Credentials), authenticationHandler.Credentials);

        //    return GetSiteData(authenticationHandler.SiteInfo, authenticationHandler.Credentials);

        //}

        //public static IApiResponse<string> GetSiteData(IApiSiteInfo apiSiteInfo, Http.ICredentials credentials)
        //{
        //    return GetSiteData(apiSiteInfo, credentials, Encoding.UTF8);
        //}

        ////TODO: rework this so the code is not dependent on a switch/conditional based on authentication type
        //public static IApiResponse<string> GetSiteData(IApiSiteInfo apiSiteInfo, Http.ICredentials credentials, Encoding encoding)
        //{
        //    Ensure.ArgumentNotNull(nameof(apiSiteInfo), apiSiteInfo);
        //    Ensure.ArgumentNotNull(nameof(credentials), credentials);
        //    Ensure.ArgumentNotNull(nameof(encoding), encoding);
        //    Ensure.ArgumentNotNull(nameof(apiSiteInfo.Route), apiSiteInfo.Route);

        //    var fullPath = CombineUrlPaths(apiSiteInfo.ApiUrl, apiSiteInfo.Route);

        //    using (var client = new WebClient())
        //    {
        //        client.BaseAddress = fullPath;
        //        client.Encoding = encoding;

        //        if (credentials.AuthenticationType == AuthenticationType.Basic)
        //        {
        //            client.Credentials = new NetworkCredential(credentials.Login, credentials.Password);
        //        }

        //        //TODO: get default parameters, actual parameters, credentials for non-basic (token, etc).

        //        try
        //        {
        //            var result = client.DownloadString(client.BaseAddress);
        //            return new ApiResponse<string>(new HttpResponse(HttpStatusCode.OK, result, client.ResponseHeaders, String.Empty) { IsError = false });
        //        }
        //        catch (WebException e)
        //        {
        //            var code = (e.Response as HttpWebResponse)?.StatusCode ?? HttpStatusCode.InternalServerError;
        //            return new ApiResponse<string>(new HttpResponse(code, e.Response.Headers)
        //            {
        //                AdditionalInformation = new Dictionary<Type, object>
        //                {
        //                    {e.Status.GetType(), e.Status},
        //                    {e.GetType(), e}
        //                }
        //            });
        //        }
        //    }
        //}

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
