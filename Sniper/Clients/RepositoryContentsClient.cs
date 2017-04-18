#if false
using System.Threading.Tasks;
using Sniper.Http;

namespace Sniper
{
    /// <summary>
    /// Client for accessing contents of files within a repository as base64 encoded content.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://developer.github.com/v3/repos/contents/">Repository Contents API documentation</a> for more information.
    /// </remarks>
    public class RepositoryContentsClient : ApiClient //, IRepositoryContentsClient
    {
        /// <summary>
        /// Create an instance of the RepositoryContentsClient
        /// </summary>
        /// <param name="apiConnection">The underlying connection to use</param>
        public RepositoryContentsClient(IApiConnection apiConnection) : base(apiConnection) {}

    
        /// <summary>
        /// Creates a commit that deletes a file in a repository.
        /// </summary>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="path">The path to the file</param>
        /// <param name="request">Information about the file to delete</param>
        public Task DeleteFile(string owner, string name, string path, DeleteFileRequest request)
        {
            Ensure.ArgumentNotNullOrEmptyString(nameof(owner), owner);
            Ensure.ArgumentNotNullOrEmptyString(nameof(name), name);
            Ensure.ArgumentNotNullOrEmptyString(nameof(path), path);
            Ensure.ArgumentNotNull(HttpKeys.RequestParameters.Request, request);

            var deleteUrl = ApiUrls.RepositoryContent(owner, name, path);
            return ApiConnection.Delete(deleteUrl, request);
        }

        /// <summary>
        /// Creates a commit that deletes a file in a repository.
        /// </summary>
        /// <param name="repositoryId">The Id of the repository</param>
        /// <param name="path">The path to the file</param>
        /// <param name="request">Information about the file to delete</param>
        public Task DeleteFile(long repositoryId, string path, DeleteFileRequest request)
        {
            Ensure.ArgumentNotNullOrEmptyString(nameof(path), path);
            Ensure.ArgumentNotNull(HttpKeys.RequestParameters.Request, request);

            var deleteUrl = ApiUrls.RepositoryContent(repositoryId, path);
            return ApiConnection.Delete(deleteUrl, request);
        }
    }
}
#endif