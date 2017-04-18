using Sniper.Http;

namespace Sniper
{
    /// <summary>
    /// A client for GitHub's Search API.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://developer.github.com/v3/search/">Search API documentation</a> for more information.
    /// </remarks>
    public class SearchClient : ApiClient, ISearchClient
    {
        /// <summary>
        /// Initializes a new GitHub Search API client.
        /// </summary>
        /// <param name="apiConnection">An API connection.</param>
        public SearchClient(IApiConnection apiConnection) : base(apiConnection) {}

        public string SearchTerm { get; set; }
    }
}