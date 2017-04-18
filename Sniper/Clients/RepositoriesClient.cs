using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Sniper.Http;
using Sniper.Request;
using Sniper.Response;
using System.Collections.Generic;
using Sniper.ApiClients;
using Sniper.Repositories;
using Sniper.ToBeRemoved;

namespace Sniper
{
    /// <summary>
    /// A client for GitHub's Repositories API.
    /// </summary>
    /// <remarks>
    /// See the <a href="http://developer.github.com/v3/repos/">Repositories API documentation</a> for more details.
    /// </remarks>
    public class RepositoriesClient : ApiClient, IRepositoriesClient
    {
        /// <summary>
        /// Initializes a new GitHub Repos API client.
        /// </summary>
        /// <param name="apiConnection">An API connection</param>
        public RepositoriesClient(IApiConnection apiConnection) : base(apiConnection)
        {
        }

        /// <summary>
        /// Creates a new repository for the current user.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/#create">API documentation</a> for more information.
        /// </remarks>
        /// <param name="newRepository">A <see cref="NewRepository"/> instance describing the new repository to create</param>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        /// <returns>A <see cref="Repository"/> instance for the created repository.</returns>
        public Task<Repository> Create(NewRepository newRepository)
        {
            Ensure.ArgumentNotNull(RepositoryKeys.NewRepository, newRepository);
            
            return Create(ApiUrls.Repositories(), null, newRepository);
        }

        /// <summary>
        /// Creates a new repository in the specified organization.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/#create">API documentation</a> for more information.
        /// </remarks>
        /// <param name="organizationLogin">Login of the organization in which to create the repository</param>
        /// <param name="newRepository">A <see cref="NewRepository"/> instance describing the new repository to create</param>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        /// <returns>A <see cref="Repository"/> instance for the created repository</returns>
        public Task<Repository> Create(string organizationLogin, NewRepository newRepository)
        {
            Ensure.ArgumentNotNull(OldGitHubToBeRemoved.OrganizationLogin, organizationLogin);
            Ensure.ArgumentNotNull(RepositoryKeys.NewRepository, newRepository);
            if (string.IsNullOrEmpty(newRepository.Name))
                throw new ArgumentException("The new repository's name must not be null.");

            return Create(ApiUrls.OrganizationRepositories(organizationLogin), organizationLogin, newRepository);
        }

        private async Task<Repository> Create(Uri url, string organizationLogin, NewRepository newRepository)
        {
            try
            {
                return await ApiConnection.Post<Repository>(url, newRepository).ConfigureAwait(false);
            }
            catch (ApiValidationException e)
            {
                string errorMessage = e.ApiError.FirstErrorMessageSafe();

                if (string.Equals(
                    "name already exists on this account",
                    errorMessage,
                    StringComparison.OrdinalIgnoreCase))
                {
                    if (string.IsNullOrEmpty(organizationLogin))
                    {
                        throw new RepositoryExistsException(newRepository.Name, e);
                    }

                    var baseAddress = Connection.BaseAddress.Host != TargetProcessClient.TargetProcessApiUrl.Host
                        ? Connection.BaseAddress
                        : new Uri("https://github.com/");
                    throw new RepositoryExistsException(
                        organizationLogin,
                        newRepository.Name,
                        baseAddress, e);
                }

                if (string.Equals(
                    "please upgrade your plan to create a new private repository.",
                    errorMessage,
                    StringComparison.OrdinalIgnoreCase))
                {
                    throw new PrivateRepositoryQuotaExceededException(e);
                }

                if (string.Equals(
                    "name can't be private. You are over your quota.",
                    errorMessage,
                    StringComparison.OrdinalIgnoreCase))
                {
                    throw new PrivateRepositoryQuotaExceededException(e);
                }

                if (errorMessage != null && errorMessage.EndsWith("is an unknown gitignore template.", StringComparison.OrdinalIgnoreCase))
                {
                    throw new InvalidGitIgnoreTemplateException(e);
                }

                throw;
            }
        }

        /// <summary>
        /// Deletes the specified repository.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/#delete-a-repository">API documentation</a> for more information.
        /// Deleting a repository requires admin access. If OAuth is used, the `delete_repo` scope is required.
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        public Task Delete(string owner, string name)
        {
            Ensure.ArgumentNotNullOrEmptyString(OldGitHubToBeRemoved.Owner, owner);
            Ensure.ArgumentNotNullOrEmptyString(OldGitHubToBeRemoved.Name, name);

            return ApiConnection.Delete(ApiUrls.Repository(owner, name));
        }

        /// <summary>
        /// Deletes the specified repository.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/#delete-a-repository">API documentation</a> for more information.
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
            Ensure.ArgumentNotNullOrEmptyString(OldGitHubToBeRemoved.Owner, owner);
            Ensure.ArgumentNotNullOrEmptyString(OldGitHubToBeRemoved.Name, name);
            Ensure.ArgumentNotNull(OldGitHubToBeRemoved.Update, update);
            Ensure.ArgumentNotNull(OldGitHubToBeRemoved.UpdateName, update.Name);

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
            Ensure.ArgumentNotNull(OldGitHubToBeRemoved.Update, update);

            return ApiConnection.Patch<Repository>(ApiUrls.Repository(repositoryId), update, AcceptHeaders.SquashCommitPreview);
        }
       
        /// <summary>
        /// Gets the specified repository.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/#get">API documentation</a> for more information.
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        /// <returns>A <see cref="Repository"/></returns>
        public Task<Repository> Get(string owner, string name)
        {
            Ensure.ArgumentNotNullOrEmptyString(OldGitHubToBeRemoved.Owner, owner);
            Ensure.ArgumentNotNullOrEmptyString(OldGitHubToBeRemoved.Name, name);

            return ApiConnection.Get<Repository>(ApiUrls.Repository(owner, name), null, AcceptHeaders.SquashCommitPreview);
        }

        /// <summary>
        /// Gets the specified repository.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/#get">API documentation</a> for more information.
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
        /// See the <a href="https://developer.github.com/v3/repos/#list-all-public-repositories">API documentation</a> for more information.
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
        /// See the <a href="https://developer.github.com/v3/repos/#list-all-public-repositories">API documentation</a> for more information.
        /// The default page size on GitHub.com is 30.
        /// </remarks>
        /// <param name="request">Search parameters of the last repository seen</param>
        /// <exception cref="AuthorizationException">Thrown if the client is not authenticated.</exception>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        /// <returns>A <see cref="IReadOnlyPagedCollection{Repository}"/> of <see cref="Repository"/>.</returns>
        public Task<IReadOnlyList<Repository>> GetAllPublic(PublicRepositoryRequest request)
        {
            Ensure.ArgumentNotNull(HttpKeys.RequestParameters.Request, request);

            var url = ApiUrls.AllPublicRepositories(request.Since);

            return ApiConnection.GetAll<Repository>(url);
        }

        /// <summary>
        /// Gets all repositories owned by the current user.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/#list-your-repositories">API documentation</a> for more information.
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
        /// See the <a href="http://developer.github.com/v3/repos/#list-your-repositories">API documentation</a> for more information.
        /// </remarks>
        /// <param name="options">Options for changing the API response</param>
        /// <exception cref="AuthorizationException">Thrown if the client is not authenticated.</exception>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        /// <returns>A <see cref="IReadOnlyPagedCollection{Repository}"/> of <see cref="Repository"/>.</returns>
        public Task<IReadOnlyList<Repository>> GetAllForCurrent(ApiOptions options)
        {
            Ensure.ArgumentNotNull(ApiClientKeys.Options, options);

            return ApiConnection.GetAll<Repository>(ApiUrls.Repositories(), options);
        }

        /// <summary>
        /// Gets all repositories owned by the current user.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/#list-your-repositories">API documentation</a> for more information.
        /// The default page size on GitHub.com is 30.
        /// </remarks>
        /// <param name="request">Search parameters to filter results on</param>
        /// <exception cref="AuthorizationException">Thrown if the client is not authenticated.</exception>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        /// <returns>A <see cref="IReadOnlyPagedCollection{Repository}"/> of <see cref="Repository"/>.</returns>
        public Task<IReadOnlyList<Repository>> GetAllForCurrent(RepositoryRequest request)
        {
            Ensure.ArgumentNotNull(HttpKeys.RequestParameters.Request, request);

            return GetAllForCurrent(request, ApiOptions.None);
        }

        public Task<IReadOnlyList<Repository>> GetAllForCurrent(RepositoryRequest request, ApiOptions options)
        {
            Ensure.ArgumentNotNull(HttpKeys.RequestParameters.Request, request);
            Ensure.ArgumentNotNull(ApiClientKeys.Options, options);

            return ApiConnection.GetAll<Repository>(ApiUrls.Repositories(), request.ToParametersDictionary(), options);
        }

        /// <summary>
        /// Gets all repositories owned by the specified user.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/#list-user-repositories">API documentation</a> for more information.
        /// The default page size on GitHub.com is 30.
        /// </remarks>
        /// <param name="login">The account name to search for</param>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        /// <returns>A <see cref="IReadOnlyPagedCollection{Repository}"/> of <see cref="Repository"/>.</returns>
        public Task<IReadOnlyList<Repository>> GetAllForUser(string login)
        {
            Ensure.ArgumentNotNullOrEmptyString(OldGitHubToBeRemoved.Login, login);

            return GetAllForUser(login, ApiOptions.None);
        }

        /// <summary>
        /// Gets all repositories owned by the specified user.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/#list-user-repositories">API documentation</a> for more information.
        /// </remarks>
        /// <param name="login">The account name to search for</param>
        /// <param name="options">Options for changing the API response</param>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        /// <returns>A <see cref="IReadOnlyPagedCollection{Repository}"/> of <see cref="Repository"/>.</returns>
        public Task<IReadOnlyList<Repository>> GetAllForUser(string login, ApiOptions options)
        {
            Ensure.ArgumentNotNullOrEmptyString(OldGitHubToBeRemoved.Login, login);
            Ensure.ArgumentNotNull(ApiClientKeys.Options, options);

            return ApiConnection.GetAll<Repository>(ApiUrls.Repositories(login), options);
        }

        /// <summary>
        /// Gets all repositories owned by the specified organization.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/#list-organization-repositories">API documentation</a> for more information.
        /// The default page size on GitHub.com is 30.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        /// <returns>A <see cref="IReadOnlyPagedCollection{Repository}"/> of <see cref="Repository"/>.</returns>
        public Task<IReadOnlyList<Repository>> GetAllForOrg(string organization)
        {
            Ensure.ArgumentNotNullOrEmptyString(OldGitHubToBeRemoved.Organization, organization);

            return GetAllForOrg(organization, ApiOptions.None);
        }

        /// <summary>
        /// Gets all repositories owned by the specified organization.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/#list-organization-repositories">API documentation</a> for more information.
        /// </remarks>
        /// <param name="organization">The organization name to search for</param>
        /// <param name="options">Options for changing the API response</param>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        /// <returns>A <see cref="IReadOnlyPagedCollection{Repository}"/> of <see cref="Repository"/>.</returns>
        public Task<IReadOnlyList<Repository>> GetAllForOrg(string organization, ApiOptions options)
        {
            Ensure.ArgumentNotNullOrEmptyString(OldGitHubToBeRemoved.Organization, organization);
            Ensure.ArgumentNotNull(ApiClientKeys.Options, options);

            return ApiConnection.GetAll<Repository>(ApiUrls.OrganizationRepositories(organization), options);
        }

     
       
        /// <summary>
        /// Gets all contributors for the specified repository. Does not include anonymous contributors.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/#list-contributors">API documentation</a> for more details
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <returns>All contributors of the repository.</returns>
        public Task<IReadOnlyList<RepositoryContributor>> GetAllContributors(string owner, string name)
        {
            Ensure.ArgumentNotNullOrEmptyString(OldGitHubToBeRemoved.Owner, owner);
            Ensure.ArgumentNotNullOrEmptyString(OldGitHubToBeRemoved.Name, name);

            return GetAllContributors(owner, name, false);
        }


        /// <summary>
        /// Gets all contributors for the specified repository. Does not include anonymous contributors.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/#list-contributors">API documentation</a> for more details
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="options">Options for changing the API response</param>
        /// <returns>All contributors of the repository.</returns>
        public Task<IReadOnlyList<RepositoryContributor>> GetAllContributors(string owner, string name, ApiOptions options)
        {
            Ensure.ArgumentNotNullOrEmptyString(OldGitHubToBeRemoved.Owner, owner);
            Ensure.ArgumentNotNullOrEmptyString(OldGitHubToBeRemoved.Name, name);
            Ensure.ArgumentNotNull(ApiClientKeys.Options, options);

            return GetAllContributors(owner, name, false, options);
        }

    
        /// <summary>
        /// Gets all contributors for the specified repository. With the option to include anonymous contributors.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/#list-contributors">API documentation</a> for more details
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="includeAnonymous">True if anonymous contributors should be included in result; Otherwise false</param>
        /// <returns>All contributors of the repository.</returns>
        public Task<IReadOnlyList<RepositoryContributor>> GetAllContributors(string owner, string name, bool includeAnonymous)
        {
            Ensure.ArgumentNotNullOrEmptyString(OldGitHubToBeRemoved.Owner, owner);
            Ensure.ArgumentNotNullOrEmptyString(OldGitHubToBeRemoved.Name, name);

            return GetAllContributors(owner, name, includeAnonymous, ApiOptions.None);
        }

        /// <summary>
        /// Gets all contributors for the specified repository. With the option to include anonymous contributors.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/#list-contributors">API documentation</a> for more details
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="includeAnonymous">True if anonymous contributors should be included in result; Otherwise false</param>
        /// <param name="options">Options for changing the API response</param>
        /// <returns>All contributors of the repository.</returns>
        public Task<IReadOnlyList<RepositoryContributor>> GetAllContributors(string owner, string name, bool includeAnonymous, ApiOptions options)
        {
            Ensure.ArgumentNotNullOrEmptyString(OldGitHubToBeRemoved.Owner, owner);
            Ensure.ArgumentNotNullOrEmptyString(OldGitHubToBeRemoved.Name, name);
            Ensure.ArgumentNotNull(ApiClientKeys.Options, options);

            var parameters = new Dictionary<string, string>();
            if (includeAnonymous)
                parameters.Add("anon", "1");

            return ApiConnection.GetAll<RepositoryContributor>(ApiUrls.RepositoryContributors(owner, name), parameters, options);
        }

       

        /// <summary>
        /// Gets all languages for the specified repository.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/#list-languages">API documentation</a> for more details
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <returns>All languages used in the repository and the number of bytes of each language.</returns>
        public async Task<IReadOnlyList<RepositoryLanguage>> GetAllLanguages(string owner, string name)
        {
            Ensure.ArgumentNotNullOrEmptyString(OldGitHubToBeRemoved.Owner, owner);
            Ensure.ArgumentNotNullOrEmptyString(OldGitHubToBeRemoved.Name, name);

            var endpoint = ApiUrls.RepositoryLanguages(owner, name);
            var data = await ApiConnection.Get<Dictionary<string, long>>(endpoint).ConfigureAwait(false);

            return new ReadOnlyCollection<RepositoryLanguage>(
                data.Select(kvp => new RepositoryLanguage(kvp.Key, kvp.Value)).ToList());
        }

  

        /// <summary>
        /// Gets all teams for the specified repository.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/#list-teams">API documentation</a> for more details
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <returns>All <see cref="T:Sniper.Team"/>s associated with the repository</returns>
        public Task<IReadOnlyList<Team>> GetAllTeams(string owner, string name)
        {
            Ensure.ArgumentNotNullOrEmptyString(OldGitHubToBeRemoved.Owner, owner);
            Ensure.ArgumentNotNullOrEmptyString(OldGitHubToBeRemoved.Name, name);

            return GetAllTeams(owner, name, ApiOptions.None);
        }

        /// <summary>
        /// Gets all teams for the specified repository.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/#list-teams">API documentation</a> for more details
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
        /// See the <a href="http://developer.github.com/v3/repos/#list-teams">API documentation</a> for more details
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="options">Options for changing the API response</param>
        /// <returns>All <see cref="T:Sniper.Team"/>s associated with the repository</returns>
        public Task<IReadOnlyList<Team>> GetAllTeams(string owner, string name, ApiOptions options)
        {
            Ensure.ArgumentNotNullOrEmptyString(OldGitHubToBeRemoved.Owner, owner);
            Ensure.ArgumentNotNullOrEmptyString(OldGitHubToBeRemoved.Name, name);
            Ensure.ArgumentNotNull(ApiClientKeys.Options, options);

            return ApiConnection.GetAll<Team>(ApiUrls.RepositoryTeams(owner, name), options);
        }

        /// <summary>
        /// Gets all teams for the specified repository.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/#list-teams">API documentation</a> for more details
        /// </remarks>
        /// <param name="repositoryId">The Id of the repository</param>
        /// <param name="options">Options for changing the API response</param>
        /// <returns>All <see cref="T:Sniper.Team"/>s associated with the repository</returns>
        public Task<IReadOnlyList<Team>> GetAllTeams(long repositoryId, ApiOptions options)
        {
            Ensure.ArgumentNotNull(ApiClientKeys.Options, options);

            return ApiConnection.GetAll<Team>(ApiUrls.RepositoryTeams(repositoryId), options);
        }
    }
}
