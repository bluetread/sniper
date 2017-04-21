using Sniper.Http;
using System;


namespace Sniper
{
    /// <summary>
    /// A Client for the Target Process API. 
    /// </summary>
    public class TargetProcessClient : ITargetProcessClient
    {
        /// <summary>
        /// The base address for the TargetProcess API
        /// </summary>
        public static readonly Uri TargetProcessApiUrl = new Uri("https://api.github.com/");  //TODO: Replace with TargetProcess 
        internal static readonly Uri TargetProcessDotComUrl = new Uri("https://github.com/");  //TODO: Replace with TargetProcess 

        /// <summary>
        /// Create a new instance of the GitHub API v3 client pointing to 
        /// https://api.github.com/ //TODO: Replace with TargetProcess 
        /// </summary>
        /// <param name="productInformation">
        /// The name (and optionally version) of the product using this library. This is sent to the server as part of
        /// the user agent for analytics purposes.
        /// </param>
        public TargetProcessClient(ProductHeaderValue productInformation) : this(new Connection(productInformation, TargetProcessApiUrl))
        {
        }

        /// <summary>
        /// Create a new instance of the GitHub API v3 client pointing to 
        /// https://api.github.com/ //TODO: Replace with TargetProcess 
        /// </summary>
        /// <param name="productInformation">
        /// The name (and optionally version) of the product using this library. This is sent to the server as part of
        /// the user agent for analytics purposes.
        /// </param>
        /// <param name="credentialStore">Provides credentials to the client when making requests</param>
        public TargetProcessClient(ProductHeaderValue productInformation, ICredentialStore credentialStore)
            : this(new Connection(productInformation, credentialStore))
        {
        }

        /// <summary>
        /// Create a new instance of the GitHub API v3 client pointing to the specified baseAddress.
        /// </summary>
        /// <param name="productInformation">
        /// The name (and optionally version) of the product using this library. This is sent to the server as part of
        /// the user agent for analytics purposes.
        /// </param>
        /// <param name="baseAddress">
        /// The address to point this client to. Typically used for GitHub Enterprise 
        /// instances</param>
        public TargetProcessClient(ProductHeaderValue productInformation, Uri baseAddress)
            : this(new Connection(productInformation, FixUpBaseUri(baseAddress)))
        {
        }

        /// <summary>
        /// Create a new instance of the GitHub API v3 client pointing to the specified baseAddress.
        /// </summary>
        /// <param name="productInformation">
        /// The name (and optionally version) of the product using this library. This is sent to the server as part of
        /// the user agent for analytics purposes.
        /// </param>
        /// <param name="credentialStore">Provides credentials to the client when making requests</param>
        /// <param name="baseAddress">
        /// The address to point this client to. Typically used for GitHub Enterprise 
        /// instances</param>
        public TargetProcessClient(ProductHeaderValue productInformation, ICredentialStore credentialStore, Uri baseAddress)
            : this(new Connection(productInformation, FixUpBaseUri(baseAddress), credentialStore))
        {
        }

        /// <summary>
        /// Create a new instance of the GitHub API v3 client using the specified connection.
        /// </summary>
        /// <param name="connection">The underlying <seealso cref="IConnection"/> used to make requests</param>
        public TargetProcessClient(IConnection connection)
        {
            Ensure.ArgumentNotNull(nameof(connection), connection);

            Connection = connection;
            var apiConnection = new ApiConnection(connection);
            Search = new SearchClient(apiConnection);
#if false
            Authorization = new AuthorizationsClient(apiConnection);
            Miscellaneous = new MiscellaneousClient(connection);
            Oauth = new OAuthClient(connection);
            Repository = new RepositoriesClient(apiConnection);
            User = new UsersClient(apiConnection);
#endif
        }

        /// <summary>
        /// Gets the latest API Info - this will be null if no API calls have been made
        /// </summary>
        /// <returns><seealso cref="ApiInfo"/> representing the information returned as part of an Api call</returns>
        public ApiInfo GetLastApiInfo()
        {
            return Connection.GetLastApiInfo();
        }

        /// <summary>
        /// Convenience property for getting and setting credentials.
        /// </summary>
        /// <remarks>
        /// You can use this property if you only have a single hard-coded credential. Otherwise, pass in an 
        /// <see cref="ICredentialStore"/> to the constructor. 
        /// Setting this property will change the <see cref="ICredentialStore"/> to use 
        /// the default <see cref="InMemoryCredentialStore"/> with just these credentials.
        /// </remarks>
        public Credentials Credentials
        {
            get { return Connection.Credentials; }
            // Note this is for convenience. We probably shouldn't allow this to be mutable.
            set
            {
                Ensure.ArgumentNotNull(nameof(value), value);
                Connection.Credentials = value;
            }
        }

        /// <summary>
        /// The base address of the GitHub API. This defaults to https://api.github.com,
        /// but you can change it if needed (to talk to a GitHub:Enterprise server for instance).
        /// </summary>
        public Uri BaseAddress => Connection.BaseAddress;

        /// <summary>
        /// Provides a client connection to make rest requests to HTTP endpoints.
        /// </summary>
        public IConnection Connection { get; }
#if false
        /// <summary>
        /// Access GitHub's Authorization API.
        /// </summary>
        /// <remarks>
        /// Refer to the API documentation for more information: https://developer.github.com/v3/oauth_authorizations/ //TODO: Replace with TargetProcess 
        /// </remarks>
        public IAuthorizationsClient Authorization { get; }

        /// <summary>
        /// Access GitHub's Miscellaneous API.
        /// </summary>
        /// <remarks>
        /// Refer to the API documentation for more information: https://developer.github.com/v3/misc/ //TODO: Replace with TargetProcess 
        /// </remarks>
        public IMiscellaneousClient Miscellaneous { get; }

        /// <summary>
        /// Access GitHub's OAuth API.
        /// </summary>
        /// <remarks>
        /// Refer to the API documentation for more information: https://developer.github.com/v3/oauth/ //TODO: Replace with TargetProcess 
        /// </remarks>
        public IOAuthClient Oauth { get; }

        /// <summary>
        /// Access GitHub's Repositories API.
        /// </summary>
        /// <remarks>
        /// Refer to the API documentation for more information: https://developer.github.com/v3/repos/ //TODO: Replace with TargetProcess 
        /// </remarks>
        public IRepositoriesClient Repository { get; }
    
        /// <summary>
        /// Access GitHub's Users API.
        /// </summary>
        /// <remarks>
        /// Refer to the API documentation for more information: https://developer.github.com/v3/users/ //TODO: Replace with TargetProcess 
        /// </remarks>
        public IUsersClient User { get; }
#endif

        /// <summary>
        /// Access GitHub's Search API.
        /// </summary>
        /// <remarks>
        /// Refer to the API documentation for more information: https://developer.github.com/v3/search/ //TODO: Replace with TargetProcess 
        /// </remarks>
        public ISearchClient Search { get; }

        private static Uri FixUpBaseUri(Uri uri) //TODO: verify all this
        {
            Ensure.ArgumentNotNull(nameof(uri), uri);

            if (uri.Host.Equals("targetprocess.com") || uri.Host.Equals("api.targetprocess.com"))
            {
                return TargetProcessApiUrl;
            }

            return new Uri(uri, new Uri("/api/v1/", UriKind.Relative)); 
        }
    }
}
