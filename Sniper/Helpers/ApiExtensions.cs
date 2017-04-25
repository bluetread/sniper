using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Sniper.Http;

namespace Sniper
{
    /// <summary>
    /// Extensions for working with the <see cref="IApiConnection"/>
    /// </summary>
    public static class ApiExtensions
    {
        /// <summary>
        /// Performs an asynchronous HTTP GET request that expects a <seealso cref="IResponse"/> containing HTML.
        /// </summary>
        /// <param name="connection">The connection to use</param>
        /// <param name="uri">URI endpoint to send request to</param>
        /// <returns><seealso cref="IResponse"/> representing the received HTTP response</returns>
        public static Task<IApiResponse<string>> GetHtml(this IConnection connection, Uri uri)
        {
            Ensure.ArgumentNotNull(nameof(connection), connection);
            Ensure.ArgumentNotNull(nameof(uri), uri);

            return connection.GetHtml(uri, null);
        }

        /// <summary>
        /// Gets the API resource at the specified URI.
        /// </summary>
        /// <typeparam name="T">Type of the API resource to get.</typeparam>
        /// <param name="connection">The connection to use</param>
        /// <param name="uri">URI of the API resource to get</param>
        /// <returns>The API resource.</returns>
        /// <exception cref="ApiException">Thrown when an API error occurs.</exception>
        public static Task<IApiResponse<T>> GetResponse<T>(this IConnection connection, Uri uri)
        {
            Ensure.ArgumentNotNull(nameof(connection), connection);
            Ensure.ArgumentNotNull(nameof(uri), uri);

            return connection.Get<T>(uri, null, null);
        }

        /// <summary>
        /// Gets the API resource at the specified URI.
        /// </summary>
        /// <typeparam name="T">Type of the API resource to get.</typeparam>
        /// <param name="connection">The connection to use</param>
        /// <param name="uri">URI of the API resource to get</param>
        /// <param name="cancellationToken">A token used to cancel the GetResponse request</param>
        /// <returns>The API resource.</returns>
        /// <exception cref="ApiException">Thrown when an API error occurs.</exception>
        public static Task<IApiResponse<T>> GetResponse<T>(this IConnection connection, Uri uri, CancellationToken cancellationToken)
        {
            Ensure.ArgumentNotNull(nameof(connection), connection);
            Ensure.ArgumentNotNull(nameof(uri), uri);

            return connection.Get<T>(uri, null, null, cancellationToken);
        }
#if false
        /// <summary>
        /// Returns true if the API call represents a true response, or false if it represents a false response.
        /// Throws an exception if the HTTP status does not match either a true or false response.
        /// </summary>
        /// <remarks>
        /// Some API endpoints return a 204 for "true" and 404 for false. See https://developer.github.com/v3/activity/starring/#check-if-you-are-starring-a-repository
        /// for one example. This encapsulates that logic.
        /// </remarks>
        /// <exception cref="ApiException">Thrown if the status is neither 204 nor 404</exception>
        /// <param name="response">True for a 204 response, False for a 404</param>
        /// <returns></returns>
        public static bool IsTrue(this IResponse response)
        {
            Ensure.ArgumentNotNull(nameof(response), response);
            
            if (response.StatusCode != HttpStatusCode.NotFound && response.StatusCode != HttpStatusCode.NoContent)
            {
                throw new ApiException("Invalid Status Code returned. Expected a 204 or a 404", response.StatusCode);
            }
            return response.StatusCode == HttpStatusCode.NoContent;
        }
#else
        //TODO: This is temporary
        public static bool IsTrue(this IResponse response)
        {
            Ensure.ArgumentNotNull(nameof(response), response);
            return HttpStatusCode.NoContent == response.StatusCode;
        }

#endif
    }
}
