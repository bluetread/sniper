#if false
using System.Threading.Tasks;
using Sniper.Http;
using Sniper.Request;
using Sniper.Response;
using System.Collections.Generic;
using Sniper.ApiClients;

namespace Sniper
{
    /// <summary>
    /// A client for GitHub's Repositories API.  //TODO: Replace with TargetProcess if this is usable
    /// </summary>
    /// <remarks>
    /// See the <a href="http://developer.github.com/v3/repos/">Repositories API documentation</a> for more details.  //TODO: Replace with TargetProcess if this is usable
    /// </remarks>
    public class RepositoriesClient : ApiClient, IRepositoriesClient
    {
        /// <summary>
        /// Initializes a new GitHub Repos API client.
        /// </summary>
        /// <param name="apiConnection">An API connection</param>
        public RepositoriesClient(IApiConnection apiConnection) : base(apiConnection) {}


        /// <summary>
        /// Deletes the specified repository.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/#delete-a-repository">API documentation</a> for more information.  //TODO: Replace with TargetProcess if this is usable
        /// Deleting a repository requires admin access. If OAuth is used, the `delete_repo` scope is required.
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        public Task Delete(string owner, string name)
        {
            Ensure.ArgumentNotNullOrEmptyString(nameof(owner), owner);
            Ensure.ArgumentNotNullOrEmptyString(nameof(name), name);

            return ApiConnection.Delete(ApiUrls.Repository(owner, name));
        }

        /// <summary>
        /// Deletes the specified repository.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/#delete-a-repository">API documentation</a> for more information.  //TODO: Replace with TargetProcess if this is usable
        /// Deleting a repository requires admin access. If OAuth is used, the `delete_repo` scope is required.
        /// </remarks>
        /// <param name="repositoryId">The Id of the repository</param>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        public Task Delete(long repositoryId)
        {
            return ApiConnection.Delete(ApiUrls.Repository(repositoryId));
        }

        /// <summary>
        /// Updates the specified repository with the values given in <paramref name="update"/>
        /// </summary>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="update">New values to update the repository with</param>
        /// <returns>The updated <see cref="T:Sniper.Repository"/></returns>
        public Task<Repository> Edit(string owner, string name, RepositoryUpdate update)
        {
            Ensure.ArgumentNotNullOrEmptyString(nameof(owner), owner);
            Ensure.ArgumentNotNullOrEmptyString(nameof(name), name);
            Ensure.ArgumentNotNull(nameof(update), update);
            Ensure.ArgumentNotNull(nameof(update.Name), update.Name);

            return ApiConnection.Patch<Repository>(ApiUrls.Repository(owner, name), update, AcceptHeaders.SquashCommitPreview);
        }

        /// <summary>
        /// Updates the specified repository with the values given in <paramref name="update"/>
        /// </summary>
        /// <param name="repositoryId">The Id of the repository</param>
        /// <param name="update">New values to update the repository with</param>
        /// <returns>The updated <see cref="T:Sniper.Repository"/></returns>
        public Task<Repository> Edit(long repositoryId, RepositoryUpdate update)
        {
            Ensure.ArgumentNotNull(nameof(update), update);

            return ApiConnection.Patch<Repository>(ApiUrls.Repository(repositoryId), update, AcceptHeaders.SquashCommitPreview);
        }
       
        /// <summary>
        /// Gets the specified repository.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/#get">API documentation</a> for more information.  //TODO: Replace with TargetProcess if this is usable
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        /// <returns>A <see cref="Repository"/></returns>
        public Task<Repository> Get(string owner, string name)
        {
            Ensure.ArgumentNotNullOrEmptyString(nameof(owner), owner);
            Ensure.ArgumentNotNullOrEmptyString(nameof(name), name);

            return ApiConnection.Get<Repository>(ApiUrls.Repository(owner, name), null, AcceptHeaders.SquashCommitPreview);
        }

        /// <summary>
        /// Gets the specified repository.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/#get">API documentation</a> for more information.  //TODO: Replace with TargetProcess if this is usable
        /// </remarks>
        /// <param name="repositoryId">The Id of the repository</param>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        /// <returns>A <see cref="Repository"/></returns>
        public Task<Repository> Get(long repositoryId)
        {
            return ApiConnection.Get<Repository>(ApiUrls.Repository(repositoryId), null, AcceptHeaders.SquashCommitPreview);
        }

        /// <summary>
        /// Gets all public repositories.
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/#list-all-public-repositories">API documentation</a> for more information.  //TODO: Replace with TargetProcess if this is usable
        /// The default page size on GitHub.com is 30.
        /// </remarks>
        /// <exception cref="AuthorizationException">Thrown if the client is not authenticated.</exception>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        /// <returns>A <see cref="IReadOnlyPagedCollection{Repository}"/> of <see cref="Repository"/>.</returns>
        public Task<IReadOnlyList<Repository>> GetAllPublic()
        {
            return ApiConnection.GetAll<Repository>(ApiUrls.AllPublicRepositories());
        }

        /// <summary>
        /// Gets all public repositories since the integer Id of the last Repository that you've seen.
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/repos/#list-all-public-repositories">API documentation</a> for more information.  //TODO: Replace with TargetProcess if this is usable
        /// The default page size on GitHub.com is 30.
        /// </remarks>
        /// <param name="request">Search parameters of the last repository seen</param>
        /// <exception cref="AuthorizationException">Thrown if the client is not authenticated.</exception>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        /// <returns>A <see cref="IReadOnlyPagedCollection{Repository}"/> of <see cref="Repository"/>.</returns>
        public Task<IReadOnlyList<Repository>> GetAllPublic(PublicRepositoryRequest request)
        {
            Ensure.ArgumentNotNull(nameof(request), request);

            var url = ApiUrls.AllPublicRepositories(request.Since);

            return ApiConnection.GetAll<Repository>(url);
        }

        /// <summary>
        /// Gets all repositories owned by the current user.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/#list-your-repositories">API documentation</a> for more information.  //TODO: Replace with TargetProcess if this is usable
        /// The default page size on GitHub.com is 30.
        /// </remarks>
        /// <exception cref="AuthorizationException">Thrown if the client is not authenticated.</exception>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        /// <returns>A <see cref="IReadOnlyPagedCollection{Repository}"/> of <see cref="Repository"/>.</returns>
        public Task<IReadOnlyList<Repository>> GetAllForCurrent()
        {
            return GetAllForCurrent(ApiOptions.None);
        }

        /// <summary>
        /// Gets all repositories owned by the current user.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/#list-your-repositories">API documentation</a> for more information.  //TODO: Replace with TargetProcess if this is usable
        /// </remarks>
        /// <param name="options">Options for changing the API response</param>
        /// <exception cref="AuthorizationException">Thrown if the client is not authenticated.</exception>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        /// <returns>A <see cref="IReadOnlyPagedCollection{Repository}"/> of <see cref="Repository"/>.</returns>
        public Task<IReadOnlyList<Repository>> GetAllForCurrent(ApiOptions options)
        {
            Ensure.ArgumentNotNull(nameof(options), options);

            return ApiConnection.GetAll<Repository>(ApiUrls.Repositories(), options);
        }

        /// <summary>
        /// Gets all repositories owned by the current user.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/#list-your-repositories">API documentation</a> for more information.  //TODO: Replace with TargetProcess if this is usable
        /// The default page size on GitHub.com is 30.
        /// </remarks>
        /// <param name="request">Search parameters to filter results on</param>
        /// <exception cref="AuthorizationException">Thrown if the client is not authenticated.</exception>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        /// <returns>A <see cref="IReadOnlyPagedCollection{Repository}"/> of <see cref="Repository"/>.</returns>
        public Task<IReadOnlyList<Repository>> GetAllForCurrent(RepositoryRequest request)
        {
            Ensure.ArgumentNotNull(nameof(request), request);

            return GetAllForCurrent(request, ApiOptions.None);
        }

        public Task<IReadOnlyList<Repository>> GetAllForCurrent(RepositoryRequest request, ApiOptions options)
        {
            Ensure.ArgumentNotNull(nameof(request), request);
            Ensure.ArgumentNotNull(nameof(options), options);

            return ApiConnection.GetAll<Repository>(ApiUrls.Repositories(), request.ToParametersDictionary(), options);
        }

        /// <summary>
        /// Gets all repositories owned by the specified user.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/#list-user-repositories">API documentation</a> for more information.  //TODO: Replace with TargetProcess if this is usable
        /// The default page size on GitHub.com is 30.
        /// </remarks>
        /// <param name="login">The account name to search for</param>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        /// <returns>A <see cref="IReadOnlyPagedCollection{Repository}"/> of <see cref="Repository"/>.</returns>
        public Task<IReadOnlyList<Repository>> GetAllForUser(string login)
        {
            Ensure.ArgumentNotNullOrEmptyString(nameof(login), login);
            
            return GetAllForUser(login, ApiOptions.None);
        }

        /// <summary>
        /// Gets all repositories owned by the specified user.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/#list-user-repositories">API documentation</a> for more information.  //TODO: Replace with TargetProcess if this is usable
        /// </remarks>
        /// <param name="login">The account name to search for</param>
        /// <param name="options">Options for changing the API response</param>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        /// <returns>A <see cref="IReadOnlyPagedCollection{Repository}"/> of <see cref="Repository"/>.</returns>
        public Task<IReadOnlyList<Repository>> GetAllForUser(string login, ApiOptions options)
        {
            Ensure.ArgumentNotNullOrEmptyString(nameof(login), login);
            Ensure.ArgumentNotNull(nameof(options), options);

            return ApiConnection.GetAll<Repository>(ApiUrls.Repositories(login), options);
        }

        /// <summary>
        /// Gets all repositories owned by the specified organization.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/#list-organization-repositories">API documentation</a> for more information.  //TODO: Replace with TargetProcess if this is usable
        /// The default page size on GitHub.com is 30.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        /// <returns>A <see cref="IReadOnlyPagedCollection{Repository}"/> of <see cref="Repository"/>.</returns>
        public Task<IReadOnlyList<Repository>> GetAllForOrg(string organization)
        {
            Ensure.ArgumentNotNullOrEmptyString(nameof(organization), organization);
            
            return GetAllForOrg(organization, ApiOptions.None);
        }

        /// <summary>
        /// Gets all repositories owned by the specified organization.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/#list-organization-repositories">API documentation</a> for more information.  //TODO: Replace with TargetProcess if this is usable
        /// </remarks>
        /// <param name="organization">The organization name to search for</param>
        /// <param name="options">Options for changing the API response</param>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        /// <returns>A <see cref="IReadOnlyPagedCollection{Repository}"/> of <see cref="Repository"/>.</returns>
        public Task<IReadOnlyList<Repository>> GetAllForOrg(string organization, ApiOptions options)
        {
            Ensure.ArgumentNotNullOrEmptyString(nameof(organization), organization);
            Ensure.ArgumentNotNull(nameof(options), options);

            return ApiConnection.GetAll<Repository>(ApiUrls.OrganizationRepositories(organization), options);
        }


        /// <summary>
        /// Gets all teams for the specified repository.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/#list-teams">API documentation</a> for more details  //TODO: Replace with TargetProcess if this is usable
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <returns>All <see cref="T:Sniper.Team"/>s associated with the repository</returns>
        public Task<IReadOnlyList<Team>> GetAllTeams(string owner, string name)
        {
            Ensure.ArgumentNotNullOrEmptyString(nameof(owner), owner);
            Ensure.ArgumentNotNullOrEmptyString(nameof(name), name);

            return GetAllTeams(owner, name, ApiOptions.None);
        }

        /// <summary>
        /// Gets all teams for the specified repository.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/#list-teams">API documentation</a> for more details  //TODO: Replace with TargetProcess if this is usable
        /// </remarks>
        /// <param name="repositoryId">The Id of the repository</param>
        /// <returns>All <see cref="T:Sniper.Team"/>s associated with the repository</returns>
        public Task<IReadOnlyList<Team>> GetAllTeams(long repositoryId)
        {
            return GetAllTeams(repositoryId, ApiOptions.None);
        }

        /// <summary>
        /// Gets all teams for the specified repository.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/#list-teams">API documentation</a> for more details  //TODO: Replace with TargetProcess if this is usable
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="options">Options for changing the API response</param>
        /// <returns>All <see cref="T:Sniper.Team"/>s associated with the repository</returns>
        public Task<IReadOnlyList<Team>> GetAllTeams(string owner, string name, ApiOptions options)
        {
            Ensure.ArgumentNotNullOrEmptyString(nameof(owner), owner);
            Ensure.ArgumentNotNullOrEmptyString(nameof(name), name);
            Ensure.ArgumentNotNull(nameof(options), options);

            return ApiConnection.GetAll<Team>(ApiUrls.RepositoryTeams(owner, name), options);
        }

        /// <summary>
        /// Gets all teams for the specified repository.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/#list-teams">API documentation</a> for more details  //TODO: Replace with TargetProcess if this is usable
        /// </remarks>
        /// <param name="repositoryId">The Id of the repository</param>
        /// <param name="options">Options for changing the API response</param>
        /// <returns>All <see cref="T:Sniper.Team"/>s associated with the repository</returns>
        public Task<IReadOnlyList<Team>> GetAllTeams(long repositoryId, ApiOptions options)
        {
            Ensure.ArgumentNotNull(nameof(options), options);

            return ApiConnection.GetAll<Team>(ApiUrls.RepositoryTeams(repositoryId), options);
        }
    }
}
#endif