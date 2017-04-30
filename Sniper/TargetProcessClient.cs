using Newtonsoft.Json;
using Sniper.Http;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using static Sniper.WarningsErrors.MessageSuppression;

namespace Sniper
{
    /// <summary>
    /// A Client for the Target Process API.
    /// </summary>
    public partial class TargetProcessClient : ITargetProcessClient
    {
        public IDictionary<string, string> DefaultQueryParameters { get; } = new Dictionary<string, string>
        {
            {ResponseFormatKeys.Format, ResponseFormatKeys.Json },
            {ResponseFormatKeys.ResultFormat, ResponseFormatKeys.Json }
        };
        public IAuthenticationHandler AuthenticationHandler { get; } = new AnonymousAuthenticator();
        public IApiSiteInfo ApiSiteInfo { get; set; } = new ApiSiteInfo();

        public TargetProcessClient() : this(true) {} 

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
                var request = new ApiRequest { BaseAddress = GetFullPath(), AuthenticationHandler = AuthenticationHandler };
                var response = ExecuteRequest<T>(request);
                return new ApiResponse<T>(new HttpResponse(response.StatusCode, response.Data));
            }

            catch (Exception exception)
            {
                return HandleExceptions<T>(exception);
            }
        }

        public async Task<IApiResponse<T>> GetDataAsync<T>()
        {
            try
            {
                var request = new ApiRequest { BaseAddress = GetFullPath(), AuthenticationHandler = AuthenticationHandler };
                var response = await ExecuteRequestAsync<T>(request);
                return new ApiResponse<T>(new HttpResponse(response.StatusCode, response.Data));
            }
            catch (Exception exception)
            {
                return HandleExceptions<T>(exception);
            }
        }

        private static ApiResponse<T> HandleExceptions<T>(Exception ex)
        {
            var exception = ex as WebException;
            if (exception != null)
            {
                var code = (exception.Response as HttpWebResponse)?.StatusCode ?? HttpStatusCode.InternalServerError;
                return new ApiResponse<T>(new HttpResponse(code, ex));
            }
            if (ex is JsonSerializationException)
            {
                return new ApiResponse<T>(new HttpResponse(ex));

            }
            return new ApiResponse<T>(new HttpResponse(ex));
        }

        private Uri GetFullPath(bool isGet = true)
        {
            if (!isGet) return new Uri(AuthenticationHandler.SiteInfo.ApiUrl);

            var fullPath = ApiSiteHelpers.CombineUrlPaths(AuthenticationHandler.SiteInfo.ApiUrl, ApiSiteInfo.Route);
            var excludeList = ApiSiteInfo.IsInclude ? new List<string>() : ApiSiteInfo.FieldList;
            var includeList = ApiSiteInfo.IsInclude ? ApiSiteInfo.FieldList : new List<string>();
            var customFilter = ApiSiteInfo.CustomFilter;
            //var formats = new Dictionary<string, string> { { setResultFormat ? ResponseFormatKeys.ResultFormat : ResponseFormatKeys.Json, ResponseFormat.Json.ToString() } };


            var dictList = new[] { DefaultQueryParameters, AuthenticationHandler.AuthenticationParameters, ApiSiteInfo.Parameters };

            var queryParameters = GetParameters(dictList);
            if (!string.IsNullOrWhiteSpace(customFilter))
            {
                queryParameters += customFilter;
            }

            return new Uri(fullPath + queryParameters);
        }

        protected IHttpResponse ExecuteRequest<T>(IApiRequest apiRequest)
        {
            Ensure.ArgumentNotNull(nameof(apiRequest), apiRequest);
            try
            {
                using (var client = new HttpClientAdapter())
                {
                    var response = client.Send(apiRequest);
                    return GetResponseData<T>(response);
                }
            }
            catch (Exception e)
            {
                return new HttpResponse(e);
            }
        }

        protected async Task<IHttpResponse> ExecuteRequestAsync<T>(IApiRequest apiRequest)
        {
            Ensure.ArgumentNotNull(nameof(apiRequest), apiRequest);
            try
            {
                using (var client = new HttpClientAdapter())
                {
                    var response = await client.SendAsync(apiRequest, CancellationToken.None);
                    return GetResponseData<T>(response);
                }
            }
            catch (Exception e)
            {
                return new HttpResponse(e);
            }
        }

        protected ICollection<T> Convert<T>(string data)
        {
            Ensure.ArgumentNotNullOrEmptyString(nameof(data), data);
            return JsonConvert.DeserializeObject<TargetProcessResponseWrapper<T>>(data).Items;
        }

        protected IHttpResponse GetResponseData<T>(IHttpResponse response)
        {
            Ensure.ArgumentNotNull(nameof(response), response);
            Ensure.ArgumentNotNull(nameof(response.Data), response.Data);

            string data = (string)response.Data;

            //To handle the return of raw data without throwing exception
            return typeof(T) == typeof(string) ? 
                new HttpResponse(HttpStatusCode.OK, data, response.ResponseHeaders) : 
                new HttpResponse(HttpStatusCode.OK, Convert<T>(data), response.ResponseHeaders);
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