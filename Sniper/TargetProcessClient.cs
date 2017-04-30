using Newtonsoft.Json;
using Sniper.Contracts;
using Sniper.Http;
using Sniper.TargetProcess.Helpers;
using Sniper.TargetProcess.Routes;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using static Sniper.WarningsErrors.MessageSuppression;
using static Sniper.CustomAttributes.CustomAttributes;
using static Sniper.SniperExceptions;

namespace Sniper
{
    /// <summary>
    /// A Client for the Target Process API.
    /// </summary>
    public partial class TargetProcessClient : ITargetProcessClient
    {
        public IApiSiteInfo ApiSiteInfo { get; set; } = new ApiSiteInfo();
        public IAuthenticationHandler AuthenticationHandler { get; } = new AnonymousAuthenticator();
        public IDictionary<string, string> DefaultQueryParameters { get; } = DefaultFormatParameters;
        protected static JsonSerializerSettings DefaultJsonSerializerSettings = new JsonSerializerSettings
        {
            DefaultValueHandling = DefaultValueHandling.Ignore,
            NullValueHandling = NullValueHandling.Ignore
        };
        protected static IDictionary<string, string> DefaultFormatParameters = new Dictionary<string, string>
        {
            {ResponseFormatKeys.Format, ResponseFormatKeys.Json },
            {ResponseFormatKeys.ResultFormat, ResponseFormatKeys.Json }
        };

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

        public IApiResponse<T> CreateData<T>(IHasId entity)
        {
            if (!VerifyEntityForCreate(entity.GetType()))
            {
                return HandleApiResponseExceptions<T>(new RequiredPropertyException());
            }

            var request = GetApiRequestFromEntity(this, entity, HttpMethod.Post);
            try
            {
                var response = ExecutePostRequest<T>(request);
                return new ApiResponse<T>(new HttpResponse(response.StatusCode, response.Data));
            }
            catch (Exception exception)
            {
                return HandleApiResponseExceptions<T>(exception);
            }
        }

        public async Task<IApiResponse<T>> CreateDataAsync<T>(IHasId entity)
        {
            var request = GetApiRequestFromEntity(this, entity, HttpMethod.Post);
            try
            {
                var response = await ExecuteGetRequestAsync<T>(request);
                return new ApiResponse<T>(new HttpResponse(response.StatusCode, response.Data));
            }
            catch (Exception exception)
            {
                return HandleApiResponseExceptions<T>(exception);
            }
        }

        [SuppressMessage(Categories.Design, MessageAttributes.DoNotCatchGeneralExceptionTypes)]
        public IApiResponse<T> GetData<T>()
        {
            var request = GetApiRequestFromEntity(this, null, HttpMethod.Get);
            try
            {
                var response = ExecuteGetRequest<T>(request);
                return new ApiResponse<T>(new HttpResponse(response.StatusCode, response.Data));
            }

            catch (Exception exception)
            {
                return HandleApiResponseExceptions<T>(exception);
            }
        }

        [SuppressMessage(Categories.Design, MessageAttributes.DoNotCatchGeneralExceptionTypes)]
        public async Task<IApiResponse<T>> GetDataAsync<T>()
        {
            var request = GetApiRequestFromEntity(this, null, HttpMethod.Get);
            try
            {
                var response = await ExecuteGetRequestAsync<T>(request);
                return new ApiResponse<T>(new HttpResponse(response.StatusCode, response.Data));
            }
            catch (Exception exception)
            {
                return HandleApiResponseExceptions<T>(exception);
            }
        }

        protected ICollection<T> Convert<T>(string data)
        {
            Ensure.ArgumentNotNullOrEmptyString(nameof(data), data);
            return JsonConvert.DeserializeObject<TargetProcessResponseWrapper<T>>(data).Items;
        }

        protected IHttpResponse ExecuteGetRequest<T>(IApiRequest apiRequest)
        {
            Ensure.ArgumentNotNull(nameof(apiRequest), apiRequest);
            try
            {
                using (var client = new HttpClientAdapter())
                {
                    var response = client.GetData(apiRequest);
                    return GetResponseData<T>(response);
                }
            }
            catch (Exception exception)
            {
                return HandleHttpResponseExceptions(exception);
            }
        }

        protected async Task<IHttpResponse> ExecuteGetRequestAsync<T>(IApiRequest apiRequest)
        {
            Ensure.ArgumentNotNull(nameof(apiRequest), apiRequest);
            try
            {
                using (var client = new HttpClientAdapter())
                {
                    var response = await client.GetDataAsync(apiRequest, CancellationToken.None);
                    return GetResponseData<T>(response);
                }
            }
            catch (Exception exception)
            {
                return HandleHttpResponseExceptions(exception);
            }
        }

        protected IHttpResponse ExecutePostRequest<T>(IApiRequest apiRequest)
        {
            Ensure.ArgumentNotNull(nameof(apiRequest), apiRequest);
            try
            {
                using (var client = new HttpClientAdapter())
                {
                    var response = client.PostData(apiRequest);
                    return GetResponseData<T>(response);
                }
            }
            catch (Exception exception)
            {
                return HandleHttpResponseExceptions(exception);
            }
        }

        protected async Task<IHttpResponse> ExecutePostRequestAsync<T>(IApiRequest apiRequest)
        {
            Ensure.ArgumentNotNull(nameof(apiRequest), apiRequest);
            try
            {
                using (var client = new HttpClientAdapter())
                {
                    var response = await client.PostDataAsync(apiRequest);
                    return GetResponseData<T>(response);
                }
            }
            catch (Exception exception)
            {
                return HandleHttpResponseExceptions(exception);
            }
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

        private static IApiRequest GetApiRequestFromEntity(
            ITargetProcessClient targetProcessClient, IHasId entity, HttpMethod httpMethod)
        {
            Ensure.ArgumentNotNull(nameof(targetProcessClient), targetProcessClient);
            Ensure.ArgumentNotNull(nameof(targetProcessClient.ApiSiteInfo), targetProcessClient.ApiSiteInfo);
            Ensure.ArgumentNotNull(nameof(targetProcessClient.AuthenticationHandler), 
                targetProcessClient.AuthenticationHandler);

            var request = new ApiRequest
            {
                AuthenticationHandler = targetProcessClient.AuthenticationHandler,
                BaseAddress = GetFullPath(targetProcessClient, httpMethod),
                Data = httpMethod == HttpMethod.Get ? null : GetSerializedEntity(entity),
                Method = httpMethod,
                Parameters = targetProcessClient.DefaultQueryParameters,
                Route = GetRouteText(entity)
            };

            return request;
        }

        private static Uri GetFullPath(ITargetProcessClient targetProcessClient, HttpMethod httpMethod)
        {
            Ensure.ArgumentNotNull(nameof(targetProcessClient), targetProcessClient);
            Ensure.ArgumentNotNull(nameof(targetProcessClient.AuthenticationHandler),
                targetProcessClient.AuthenticationHandler);
            Ensure.ArgumentNotNull(nameof(targetProcessClient.AuthenticationHandler.SiteInfo),
                targetProcessClient.AuthenticationHandler.SiteInfo);

            if (httpMethod == HttpMethod.Post) return new Uri(targetProcessClient.AuthenticationHandler.SiteInfo.ApiUrl);

            var fullPath = ApiSiteHelpers.CombineUrlPaths(
                targetProcessClient.AuthenticationHandler.SiteInfo.ApiUrl,
                targetProcessClient.ApiSiteInfo.Route);

            var excludeList = targetProcessClient.ApiSiteInfo.IsInclude
                ? new List<string>()
                : targetProcessClient.ApiSiteInfo.FieldList;

            var includeList = targetProcessClient.ApiSiteInfo.IsInclude
                ? targetProcessClient.ApiSiteInfo.FieldList
                : new List<string>();

            var customFilter = targetProcessClient.ApiSiteInfo.CustomFilter;

            var dictList = new[]
            {
                targetProcessClient.DefaultQueryParameters,
                targetProcessClient.AuthenticationHandler.AuthenticationParameters,
                targetProcessClient.ApiSiteInfo.Parameters
            };

            var queryParameters = GetParameters(dictList);
            if (!string.IsNullOrWhiteSpace(customFilter))
            {
                queryParameters += customFilter;
            }

            return new Uri(fullPath + queryParameters);
        }

        private static string GetParameters(IEnumerable<IDictionary<string, string>> orderedList)
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

        private static string GetRouteText(IHasId entity)
        {
            if (entity == null) return string.Empty;

            return TargetProcessHelpers.ResourceTypeRoutes.TryGetValue(entity.GetType(),
                out TargetProcessRoutes.Route route) ? route.ToLowerCase() : string.Empty;
        }

        private static string GetSerializedEntity(IHasId entity)
        {
            return JsonConvert.SerializeObject(entity, Formatting.None, DefaultJsonSerializerSettings);
        }

        private static ApiResponse<T> HandleApiResponseExceptions<T>(Exception ex)
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

        private static IHttpResponse HandleHttpResponseExceptions(Exception ex)
        {
            return new HttpResponse(ex);
        }

        private static bool VerifyEntityForCreate(Type entityType)
        {
            var list = entityType.PropertyNamesWithAttribute<RequiredForCreateAttribute>();
            return true;
        }
    }
}