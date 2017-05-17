using Sniper.Net;
using Sniper.Types;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Sniper.Authentication.AuthenticationKeys;
using static Sniper.WarningsErrors.MessageSuppression;

namespace Sniper.Http
{
    internal class RedirectHandler : DelegatingHandler { }

    /// <summary>
    /// Generic Http client. Useful for those who want to swap out System.Net.HttpClient with something else.
    /// </summary>
    /// <remarks>
    /// Most folks won't ever need to swap this out. But if you're trying to run this on Windows Phone, you might.
    /// </remarks>
    public class HttpClientAdapter : IHttpClient
    {
        private readonly HttpClient _httpClient;

        public const int MaxRedirects = 3;
        public const int PermanentRedirect = 308;
        public const string RedirectCountKey = "RedirectCount";

        private static IEnumerable<string> DefaultBinaryContentTypes => new[]
        {
            MimeTypes.ApplicationZip,
            MimeTypes.ApplicationXGzip,
            MimeTypes.ApplicationOctetStream
        };

        public HttpClientAdapter() : this(HttpMessageHandlerFactory.CreateDefault) { }

        [SuppressMessage(Categories.Reliability, MessageAttributes.DisposeObjectsBeforeLosingScope)]
        public HttpClientAdapter(Func<HttpMessageHandler> getHandler)
        {
            Ensure.ArgumentNotNull(nameof(getHandler), getHandler);

            _httpClient = new HttpClient(new RedirectHandler { InnerHandler = getHandler() });
        }

        ~HttpClientAdapter()
        {
            Dispose(false);
        }

        public IHttpResponse DeleteData(IApiRequest request)
        {
            Ensure.ArgumentNotNull(nameof(request), request);

            using (var client = new WebClient())
            {
                client.BaseAddress = request.BaseAddress.ToString();
                client.Credentials = request.AuthenticationHandler.NetworkCredentials;
                try
                {
                    var byteArray = client.UploadValues(client.BaseAddress, HttpMethod.Delete.Method, new NameValueCollection());
                    var result = Encoding.UTF8.GetString(byteArray);
                    return new HttpResponse(HttpStatusCode.OK, result);
                }
                catch (WebException webException)
                {
                    var code = (webException.Response as HttpWebResponse)?.StatusCode ?? HttpStatusCode.InternalServerError;
                    return new HttpResponse(code, webException);
                }
                catch (Exception e)
                {
                    return new HttpResponse(e);
                }
            }
        }

        public async Task<IHttpResponse> DeleteDataAsync(IApiRequest request)
        {
            Ensure.ArgumentNotNull(nameof(request), request);

            using (var requestMessage = BuildRequestMessage(request))
            {
                using (var httpResponseMessage = await GetResponseMessageForDeleteAsync(requestMessage, CancellationToken.None))
                {
                    return await BuildResponseAsync(httpResponseMessage).ConfigureAwait(false);
                }
            }
        }
        /// <summary>
        /// Sends the specified request and returns a response.
        /// </summary>
        /// <param name="request">A <see cref="IApiRequest"/> that represents the HTTP request</param>
        /// <returns>A <see cref="Task" /> of <see cref="IHttpResponse"/></returns>
        public IHttpResponse GetData(IApiRequest request)
        {
            Ensure.ArgumentNotNull(nameof(request), request);

            using (var client = new WebClient())
            {
                client.BaseAddress = request.BaseAddress.ToString();
                client.Credentials = request.AuthenticationHandler.NetworkCredentials;
                try
                {
                    var result = client.DownloadString(client.BaseAddress);
                    return new HttpResponse(HttpStatusCode.OK, result);
                }
                catch (WebException webException)
                {
                    var code = (webException.Response as HttpWebResponse)?.StatusCode ?? HttpStatusCode.InternalServerError;
                    return new HttpResponse(code, webException);
                }
                catch (Exception e)
                {
                    return new HttpResponse(e);
                }
            }
        }

        /// <summary>
        /// Sends the specified request and returns a response.
        /// </summary>
        /// <param name="request">A <see cref="IApiRequest"/> that represents the HTTP request</param>
        /// <returns>A <see cref="Task" /> of <see cref="IHttpResponse"/></returns>
        public async Task<IHttpResponse> GetDataAsync(IApiRequest request)
        {
            Ensure.ArgumentNotNull(nameof(request), request);
            return await GetDataAsync(request, CancellationToken.None);
        }

        /// <summary>
        /// Sends the specified request and returns a response.
        /// </summary>
        /// <param name="request">A <see cref="IApiRequest"/> that represents the HTTP request</param>
        /// <param name="cancellationToken">Used to cancel the request</param>
        /// <returns>A <see cref="Task" /> of <see cref="IHttpResponse"/></returns>
        public async Task<IHttpResponse> GetDataAsync(IApiRequest request, CancellationToken cancellationToken)
        {
            Ensure.ArgumentNotNull(nameof(request), request);

            var cancellationTokenForRequest = GetCancellationTokenForRequest(request, cancellationToken);

            using (var requestMessage = BuildRequestMessage(request))
            {
                using (var httpResponseMessage = await GetResponseMessageAsync(requestMessage, request, cancellationTokenForRequest))
                {
                    return await BuildResponseAsync(httpResponseMessage).ConfigureAwait(false);
                }
            }
        }

        public IHttpResponse PostData(IApiRequest request)
        {
            Ensure.ArgumentNotNull(nameof(request), request);

            using (var requestMessage = BuildRequestMessage(request))
            {
                using (var httpResponseMessage = GetResponseMessageForPostAsync(requestMessage, request).Result)
                {
                    return BuildResponse(httpResponseMessage);
                }
            }
        }

        public async Task<IHttpResponse> PostDataAsync(IApiRequest request)
        {
            Ensure.ArgumentNotNull(nameof(request), request);

            using (var requestMessage = BuildRequestMessage(request))
            {
                using (var httpResponseMessage = await GetResponseMessageForPostAsync(requestMessage, request))
                {
                    return await BuildResponseAsync(httpResponseMessage).ConfigureAwait(false);
                }
            }
        }

#if false
        public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            // Clone the request/content incase we get a redirect
            var clonedRequest = await CloneHttpRequestMessageAsync(request).ConfigureAwait(false);

            // Send initial response
            var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseContentRead, cancellationToken).ConfigureAwait(false);

            // Can't redirect without somewhere to redirect to.
            if (response.Headers.Location == null)
            {
                return response;
            }

            // Don't redirect if we exceed max number of redirects
            var redirectCount = 0;
            if (request.Properties.Keys.Contains(RedirectCountKey))
            {
                redirectCount = (int)request.Properties[RedirectCountKey];
            }
            if (redirectCount > MaxRedirects)
            {
                throw new InvalidOperationException("The redirect count for this request has been exceeded. Aborting."); //TODO:const
            }

            if (response.StatusCode == HttpStatusCode.MovedPermanently
                || response.StatusCode == HttpStatusCode.Redirect
                || response.StatusCode == HttpStatusCode.Found
                || response.StatusCode == HttpStatusCode.SeeOther
                || response.StatusCode == HttpStatusCode.TemporaryRedirect
                || (int)response.StatusCode == PermanentRedirect)
            {
                if (response.StatusCode == HttpStatusCode.SeeOther)
                {
                    clonedRequest.Content = null;
                    clonedRequest.Method = HttpMethod.Get;
                }

                // Increment the redirect count
                clonedRequest.Properties[RedirectCountKey] = ++redirectCount;

                // Set the new Uri based on location header
                clonedRequest.RequestUri = response.Headers.Location;

                // Clear authentication if redirected to a different host
                if (string.Compare(clonedRequest.RequestUri.Host, request.RequestUri.Host, StringComparison.OrdinalIgnoreCase) != 0)
                {
                    clonedRequest.Headers.Authorization = null;
                }

                // Send redirected request
                response = await SendAsync(clonedRequest, cancellationToken).ConfigureAwait(false);
            }

            return response;
        }

        public static async Task<HttpRequestMessage> CloneHttpRequestMessageAsync(HttpRequestMessage oldRequest)
        {
            var newRequest = new HttpRequestMessage(oldRequest.Method, oldRequest.RequestUri);

            // Copy the request's content (via a MemoryStream) into the cloned object
            var ms = new MemoryStream();
            if (oldRequest.Content != null)
            {
                await oldRequest.Content.CopyToAsync(ms).ConfigureAwait(false);
                ms.Position = 0;
                newRequest.Content = new StreamContent(ms);

                // Copy the content headers
                if (oldRequest.Content.Headers != null)
                {
                    foreach (var h in oldRequest.Content.Headers)
                    {
                        newRequest.Content.Headers.Add(h.Key, h.Value);
                    }
                }
            }

            newRequest.Version = oldRequest.Version;

            foreach (var header in oldRequest.Headers)
            {
                newRequest.Headers.TryAddWithoutValidation(header.Key, header.Value);
            }

            foreach (var property in oldRequest.Properties)
            {
                newRequest.Properties.Add(property);
            }

            return newRequest;
        }
#endif
        protected virtual HttpRequestMessage BuildRequestMessage(IApiRequest request)
        {
            Ensure.ArgumentNotNull(nameof(request), request);
            HttpRequestMessage requestMessage = null;
            try
            {
                var fullUri = request.BaseAddress;
                requestMessage = new HttpRequestMessage(request.Method, fullUri);

                foreach (var header in request.Headers)
                {
                    requestMessage.Headers.Add(header.Key, header.Value);
                }

                var httpContent = request.Data as HttpContent;
                if (httpContent != null)
                {
                    requestMessage.Content = httpContent;
                }

                var body = request.Data as string;
                if (body != null)
                {
                    requestMessage.Content = new StringContent(body, Encoding.UTF8, request.ContentType);
                }

                var bodyStream = request.Data as Stream;
                if (bodyStream != null)
                {
                    requestMessage.Content = new StreamContent(bodyStream);
                    requestMessage.Content.Headers.ContentType = new MediaTypeHeaderValue(request.ContentType);
                }

                if (request.AuthenticationHandler != null && request.AuthenticationHandler.GetType() == typeof(BasicAuthenticator))
                {
                    requestMessage.Headers.Authorization = new AuthenticationHeaderValue(Keys.Basic, ApiSiteHelpers.GetBasicCredentials((BasicAuthenticator)request.AuthenticationHandler));
                }
            }
            catch (Exception)
            {
                requestMessage?.Dispose();
                throw;
            }

            return requestMessage;
        }

        protected virtual IHttpResponse BuildResponse(HttpResponseMessage responseMessage)
        {
            Ensure.ArgumentNotNull(nameof(responseMessage), responseMessage);

            object responseBody;
            string contentType;

            using (var content = responseMessage.Content)
            {
                if (content == null) return new HttpResponse(responseMessage.StatusCode, null, responseMessage.Headers, null);

                contentType = GetContentMediaType(content);
                responseBody = IsBinaryContent(contentType) ? (object)GetContentBytes(content) : GetContentString(content);
            }
            return new HttpResponse(responseMessage.StatusCode, responseBody, responseMessage.Headers, contentType);
        }

        protected virtual async Task<IHttpResponse> BuildResponseAsync(HttpResponseMessage responseMessage)
        {
            Ensure.ArgumentNotNull(nameof(responseMessage), responseMessage);

            object responseBody;
            string contentType;

            using (var content = responseMessage.Content)
            {
                if (content == null) return new HttpResponse(responseMessage.StatusCode, null, responseMessage.Headers, null);

                contentType = GetContentMediaType(content);
                responseBody = IsBinaryContent(contentType) ? (object)await GetContentBytesAsync(content) : await GetContentStringAsync(content);
            }
            return new HttpResponse(responseMessage.StatusCode, responseBody, responseMessage.Headers, contentType);
        }

        protected virtual async Task<HttpResponseMessage> GetResponseMessageAsync(
            HttpRequestMessage requestMessage, IApiRequest apiRequest, CancellationToken cancellationToken)
        {
            if (apiRequest.Method == HttpMethod.Post)
                return await GetResponseMessageForPostAsync(requestMessage, apiRequest);

            return await GetResponseMessageForGetAsync(requestMessage, cancellationToken);
        }

        [SuppressMessage(Categories.Reliability, MessageAttributes.DisposeObjectsBeforeLosingScope)]
        private static CancellationToken GetCancellationTokenForRequest(IApiRequest request, CancellationToken cancellationToken)
        {
            var cancellationTokenForRequest = cancellationToken;

            if (request.Timeout == TimeSpan.Zero) return cancellationTokenForRequest;
            var timeoutCancellation = new CancellationTokenSource(request.Timeout);
            var unifiedCancellationToken = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken, timeoutCancellation.Token);

            cancellationTokenForRequest = unifiedCancellationToken.Token;
            return cancellationTokenForRequest;
        }

        private byte[] GetContentBytes(HttpContent content)
        {
            Ensure.ArgumentNotNull(nameof(content), content);
            return content.ReadAsByteArrayAsync().Result;
        }

        private async Task<byte[]> GetContentBytesAsync(HttpContent content)
        {
            Ensure.ArgumentNotNull(nameof(content), content);
            return await content.ReadAsByteArrayAsync().ConfigureAwait(false);
        }

        private static string GetContentMediaType(HttpContent httpContent)
        {
            return httpContent.Headers?.ContentType?.MediaType;
        }

        private string GetContentString(HttpContent content)
        {
            Ensure.ArgumentNotNull(nameof(content), content);
            return content.ReadAsStringAsync().Result;
        }

        private async Task<string> GetContentStringAsync(HttpContent content)
        {
            Ensure.ArgumentNotNull(nameof(content), content);
            return await content.ReadAsStringAsync().ConfigureAwait(false);
        }

        private static bool IsBinaryContent(string contentType)
        {
            Ensure.ArgumentNotNullOrEmptyString(nameof(contentType), contentType);

            return contentType != null && (contentType.StartsWith(MimeTypes.ImagePrefix) ||
                                           DefaultBinaryContentTypes.Any(λ => λ.Equals(contentType, StringComparison.OrdinalIgnoreCase)));
        }

        private async Task<HttpResponseMessage> GetResponseMessageForDeleteAsync(HttpRequestMessage requestMessage, CancellationToken cancellationToken)
        {
            Ensure.ArgumentNotNull(nameof(requestMessage), requestMessage);
            try
            {
                var address = requestMessage.RequestUri;
                var responseMessage = await _httpClient.DeleteAsync(address, cancellationToken);
                return responseMessage;
            }
            catch (WebException webException)
            {
                var code = (webException.Response as HttpWebResponse)?.StatusCode ?? HttpStatusCode.InternalServerError;
                return new HttpResponseMessage(code);
            }
            catch (Exception)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
        }


        private async Task<HttpResponseMessage> GetResponseMessageForGetAsync(HttpRequestMessage requestMessage, CancellationToken cancellationToken)
        {
            Ensure.ArgumentNotNull(nameof(requestMessage), requestMessage);
            try
            {
                var responseMessage = await _httpClient.SendAsync(requestMessage, cancellationToken);
                return responseMessage;
            }
            catch (WebException webException)
            {
                var code = (webException.Response as HttpWebResponse)?.StatusCode ?? HttpStatusCode.InternalServerError;
                return new HttpResponseMessage(code);
            }
            catch (Exception)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
        }

        private async Task<HttpResponseMessage> GetResponseMessageForPostAsync(HttpRequestMessage requestMessage, IApiRequest request)
        {
            Ensure.ArgumentNotNull(nameof(requestMessage), requestMessage);

            ServicePointManager.SecurityProtocol = Security.DefaultSecurityProtocolType;

            //TODO: check if even needed
            _httpClient.BaseAddress = new Uri(requestMessage.RequestUri + (requestMessage.RequestUri.ToString().EndsWith(@"/") ? string.Empty : @"/"));

            if (request.AuthenticationHandler != null && request.AuthenticationHandler.GetType() == typeof(BasicAuthenticator))
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                    Keys.Basic, ApiSiteHelpers.GetBasicCredentials((BasicAuthenticator)request.AuthenticationHandler));
            }

            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(MimeTypes.ApplicationJson));

            try
            {
                var responseMessage = await _httpClient.PostAsync(request.Route, requestMessage.Content);
                return responseMessage;

            }
            catch (WebException webException)
            {
                var code = (webException.Response as HttpWebResponse)?.StatusCode ?? HttpStatusCode.InternalServerError;
                return new HttpResponseMessage(code);
            }
            catch (Exception)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
        }


        #region Dispose

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            // ReSharper disable once UseNullPropagation // Causes error when using  _http?.Dispose();
            if (disposing && _httpClient != null)
            {
                _httpClient.Dispose();
            }
        }

        #endregion
    }
}
