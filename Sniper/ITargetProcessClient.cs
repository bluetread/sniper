using Sniper.Http;

namespace Sniper
{
    /// <summary>
    /// A Client for the GitHub API v3. You can read more about the api here: http://developer.github.com.
    /// </summary>
    public interface ITargetProcessClient : IApiInfoProvider
    {
        /// <summary>
        /// Provides a client connection to make rest requests to HTTP endpoints.
        /// </summary>
        IConnection Connection { get; }

        /// <summary>
        /// Access GitHub's Authorization API.
        /// </summary>
        /// <remarks>
        /// Refer to the API documentation for more information: https://developer.github.com/v3/oauth_authorizations/
        /// </remarks>
        IAuthorizationsClient Authorization { get; }


        /// <summary>
        /// Access GitHub's Miscellaneous API.
        /// </summary>
        /// <remarks>
        /// Refer to the API documentation for more information: https://developer.github.com/v3/misc/
        /// </remarks>
        IMiscellaneousClient Miscellaneous { get; }

        /// <summary>
        /// Access GitHub's OAuth API.
        /// </summary>
        /// <remarks>
        /// Refer to the API documentation for more information: https://developer.github.com/v3/oauth/
        /// </remarks>
        IOAuthClient Oauth { get; }

    

        /// <summary>
        /// Access GitHub's Repositories API.
        /// </summary>
        /// <remarks>
        /// Refer to the API documentation for more information: https://developer.github.com/v3/repos/
        /// </remarks>
        IRepositoriesClient Repository { get; }
      
        /// <summary>
        /// Access GitHub's Users API.
        /// </summary>
        /// <remarks>
        /// Refer to the API documentation for more information: https://developer.github.com/v3/users/
        /// </remarks>
        IUsersClient User { get; }

        /// <summary>
        /// Access GitHub's Search API.
        /// </summary>
        /// <remarks>
        /// Refer to the API documentation for more information: https://developer.github.com/v3/search/
        /// </remarks>
        ISearchClient Search { get; }
    }
}
