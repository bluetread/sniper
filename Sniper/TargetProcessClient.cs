using Newtonsoft.Json;
using Sniper.Http;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using static Sniper.WarningsErrors.MessageSuppression;

namespace Sniper
{
    /// <summary>
    /// A Client for the Target Process API.
    /// </summary>
    public partial class TargetProcessClient : ITargetProcessClient
    {
        public IDictionary<string, string> DefaultQueryParameters { get; } = new Dictionary<string, string>();
        public IAuthenticationHandler AuthenticationHandler { get; } = new AnonymousAuthenticator();
        public IApiSiteInfo ApiSiteInfo { get; set; } = new ApiSiteInfo();

        public TargetProcessClient() { }

        public TargetProcessClient(bool useConfigHandler)
        {
            if (useConfigHandler)
                AuthenticationHandler = AuthenticatorFactory.GetAuthenticationHandlerFromConfig();
        }

        public TargetProcessClient(IAuthenticationHandler authenticationHandler) : this()
        {
            Ensure.ArgumentNotNull(nameof(authenticationHandler), authenticationHandler);
            AuthenticationHandler = authenticationHandler;
        }

        public TargetProcessClient(IAuthenticationHandler authenticationHandler, IApiSiteInfo apiSiteInfo) : this(authenticationHandler)
        {
            Ensure.ArgumentNotNull(nameof(apiSiteInfo), apiSiteInfo);
        }

        [SuppressMessage(Categories.Design, MessageAttributes.DoNotCatchGeneralExceptionTypes)]
        [SuppressMessage(Categories.Design, MessageAttributes.UsePropertiesWhereAppropriate)]
        [SuppressMessage(Categories.Performance, "CA1804:RemoveUnusedLocals")]
        public IApiResponse<T> GetData<T>()
        {
            try
            {
                var fullPath = ApiSiteHelpers.CombineUrlPaths(AuthenticationHandler.SiteInfo.ApiUrl, ApiSiteInfo.Route);
                var excludeList = ApiSiteInfo.IsInclude ? new List<string>() : ApiSiteInfo.FieldList;
                var includeList = ApiSiteInfo.IsInclude ? ApiSiteInfo.FieldList : new List<string>();
                var customFilter = ApiSiteInfo.CustomFilter;

                var dictList = new[] { DefaultQueryParameters, AuthenticationHandler.AuthenticationParameters, ApiSiteInfo.Parameters };

                var queryParameters = GetParameters(dictList);
                if (!string.IsNullOrWhiteSpace(customFilter))
                {
                    queryParameters += customFilter;
                }

                var fullPathAndQueryParameters = fullPath + queryParameters;

                using (var client = new WebClient())
                {
                    client.BaseAddress = fullPathAndQueryParameters;
                    client.Credentials = AuthenticationHandler.NetworkCredentials;
                    var result = client.DownloadString(client.BaseAddress);

                    //To handle the return of raw data without throwing exception
                    if (typeof(T) == typeof(string))
                    {
                        return new ApiResponse<T>(new HttpResponse(HttpStatusCode.OK, result, client.ResponseHeaders) { IsError = false });
                    }
                    var items = JsonConvert.DeserializeObject<TargetProcessResponseWrapper<T>>(result).Items;
                    return new ApiResponse<T>(new HttpResponse(HttpStatusCode.OK, items, client.ResponseHeaders) { IsError = false });
                }
            }
            catch (WebException webException)
            {
                var code = (webException.Response as HttpWebResponse)?.StatusCode ?? HttpStatusCode.InternalServerError;
                return new ApiResponse<T>(new HttpResponse(code, webException));
            }
            catch (Exception e)
            {
                return new ApiResponse<T>(new HttpResponse(e));
            }
        }

        private static string GetParameters(IDictionary<string, string>[] orderedList)
        {
            var finalList = new Dictionary<string, string>();
            foreach (var dict in orderedList)
            {
                //Add (or replace) entries into one combined dictionary
                foreach (var kvp in dict)
                {
                    finalList[kvp.Key] = kvp.Value;
                }
            }
            return finalList.ToQueryString();
        }
    }
}