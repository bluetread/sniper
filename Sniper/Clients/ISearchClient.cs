namespace Sniper
{
    /// <summary>
    /// A client for GitHub's Search API.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://developer.github.com/v3/search/">Search API documentation</a> for more information.  //TODO: Replace with TargetProcess if this is usable
    /// </remarks>
    public interface ISearchClient
    {
        string SearchTerm { get; set; }
    }
}