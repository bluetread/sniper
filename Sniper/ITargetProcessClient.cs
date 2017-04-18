using Sniper.Http;

namespace Sniper
{
    /// <summary>
    /// A Client for the TargetProcess API. You can read more about the api here: http://developer.github.com. //TODO
    /// </summary>
    public interface ITargetProcessClient : IApiInfoProvider
    {
        /// <summary>
        /// Provides a client connection to make rest requests to HTTP endpoints.
        /// </summary>
        IConnection Connection { get; }


        /// <summary>
        /// Access GitHub's Search API.
        /// </summary>
        /// <remarks>
        /// Refer to the API documentation for more information: https://developer.github.com/v3/search/ //TODO
        /// </remarks>
        ISearchClient Search { get; }
    }
}
