#if false
using System.Threading.Tasks;
using Sniper.Request;
using Sniper.Response;

namespace Sniper
{
    /// <summary>
    /// A client for GitHub's Git Blobs API.  //TODO: Replace with TargetProcess if this is usable
    /// </summary>
    /// <remarks>
    /// See the <a href="http://developer.github.com/v3/git/blobs/">Git Blobs API documentation</a> for more information.  //TODO: Replace with TargetProcess if this is usable
    /// </remarks>
    public interface IBlobsClient
    {
        /// <summary>
        /// Gets a single Blob by SHA.
        /// </summary>
        /// <remarks>
        /// http://developer.github.com/v3/git/blobs/#get-a-blob  //TODO: Replace with TargetProcess if this is usable
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="reference">The SHA of the blob</param>
        [SuppressMessage(Categories.Naming, "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Get")]
        Task<Blob> Get(string owner, string name, string reference);

        /// <summary>
        /// Gets a single Blob by SHA.
        /// </summary>
        /// <remarks>
        /// http://developer.github.com/v3/git/blobs/#get-a-blob  //TODO: Replace with TargetProcess if this is usable
        /// </remarks>
        /// <param name="repositoryId">The Id of the repository</param>
        /// <param name="reference">The SHA of the blob</param>
        [SuppressMessage(Categories.Naming, "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Get")]
        Task<Blob> Get(long repositoryId, string reference);

        /// <summary>
        /// Creates a new Blob
        /// </summary>
        /// <remarks>
        /// http://developer.github.com/v3/git/blobs/#create-a-blob  //TODO: Replace with TargetProcess if this is usable
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="newBlob">The new Blob</param>
        Task<BlobReference> Create(string owner, string name, NewBlob newBlob);

        /// <summary>
        /// Creates a new Blob
        /// </summary>
        /// <remarks>
        /// http://developer.github.com/v3/git/blobs/#create-a-blob  //TODO: Replace with TargetProcess if this is usable
        /// </remarks>
        /// <param name="repositoryId">The Id of the repository</param>
        /// <param name="newBlob">The new Blob</param>
        Task<BlobReference> Create(long repositoryId, NewBlob newBlob);
    }
}
#endif