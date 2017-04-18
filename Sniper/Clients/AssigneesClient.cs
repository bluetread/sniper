using System.Collections.Generic;
using System.Threading.Tasks;
using Sniper.ApiClients;
using Sniper.Http;
using Sniper.Request;
using Sniper.Response;
using Sniper.ToBeRemoved;

namespace Sniper
{
    /// <summary>
    /// A client for GitHub's Issue Assignees API.
    /// </summary>
    public class AssigneesClient : ApiClient, IAssigneesClient
    {
        /// <summary>
        /// Instantiates a new GitHub Issue Assignees API client.
        /// </summary>
        /// <param name="apiConnection">An API connection</param>
        public AssigneesClient(IApiConnection apiConnection) : base(apiConnection)
        {
        }

        /// <summary>
        /// Gets all the available assignees (owner + collaborators) to which issues may be assigned.
        /// </summary>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        public Task<IReadOnlyList<User>> GetAllForRepository(string owner, string name)
        {
            Ensure.ArgumentNotNullOrEmptyString(OldGitHubToBeRemoved.Owner, owner);
            Ensure.ArgumentNotNullOrEmptyString(OldGitHubToBeRemoved.Name, name);

            return GetAllForRepository(owner, name, ApiOptions.None);
        }

        /// <summary>
        /// Gets all the available assignees (owner + collaborators) to which issues may be assigned.
        /// </summary>
        /// <param name="repositoryId">The Id of the repository</param>
        public Task<IReadOnlyList<User>> GetAllForRepository(long repositoryId)
        {
            return GetAllForRepository(repositoryId, ApiOptions.None);
        }

        /// <summary>
        /// Gets all the available assignees (owner + collaborators) to which issues may be assigned.
        /// </summary>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="options">The options to change API's response.</param>
        public Task<IReadOnlyList<User>> GetAllForRepository(string owner, string name, ApiOptions options)
        {
            Ensure.ArgumentNotNullOrEmptyString(OldGitHubToBeRemoved.Owner, owner);
            Ensure.ArgumentNotNullOrEmptyString(OldGitHubToBeRemoved.Name, name);
            Ensure.ArgumentNotNull(ApiClientKeys.Options, options);

            var endpoint = ApiUrls.Assignees(owner, name);

            return ApiConnection.GetAll<User>(endpoint, null, AcceptHeaders.StableVersion, options);
        }

        /// <summary>
        /// Gets all the available assignees (owner + collaborators) to which issues may be assigned.
        /// </summary>
        /// <param name="repositoryId">The Id of the repository</param>
        /// <param name="options">The options to change API's response.</param>
        public Task<IReadOnlyList<User>> GetAllForRepository(long repositoryId, ApiOptions options)
        {
            Ensure.ArgumentNotNull(ApiClientKeys.Options, options);

            var endpoint = ApiUrls.Assignees(repositoryId);

            return ApiConnection.GetAll<User>(endpoint, null, AcceptHeaders.StableVersion, options);
        }

        /// <summary>
        /// Checks to see if a user is an assignee for a repository.
        /// </summary>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="assignee">Username of the prospective assignee</param>
        public async Task<bool> CheckAssignee(string owner, string name, string assignee)
        {
            Ensure.ArgumentNotNullOrEmptyString(OldGitHubToBeRemoved.Owner, owner);
            Ensure.ArgumentNotNullOrEmptyString(OldGitHubToBeRemoved.Name, name);
            Ensure.ArgumentNotNullOrEmptyString(OldGitHubToBeRemoved.Assignee, assignee);

            try
            {
                var response = await Connection.Get<object>(ApiUrls.CheckAssignee(owner, name, assignee), null, null).ConfigureAwait(false);
                return response.HttpResponse.IsTrue();
            }
            catch (NotFoundException)
            {
                return false;
            }
        }

        /// <summary>
        /// Add assignees to a specified Issue.
        /// </summary>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="number">The issue number</param>
        /// <param name="assignees">List of names of assignees to add</param>
        /// <returns></returns>
        public Task<Issue> AddAssignees(string owner, string name, int number, AssigneesUpdate assignees)
        {
            Ensure.ArgumentNotNullOrEmptyString(OldGitHubToBeRemoved.Owner, owner);
            Ensure.ArgumentNotNullOrEmptyString(OldGitHubToBeRemoved.Name, name);
            Ensure.ArgumentNotNull(OldGitHubToBeRemoved.Assignees, assignees);

            return ApiConnection.Post<Issue>(ApiUrls.IssueAssignees(owner, name, number), assignees);
        }

        /// <summary>
        /// Remove assignees from a specified Issue.
        /// </summary>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="number">The issue number</param>
        /// <param name="assignees">List of assignees to remove</param>
        /// <returns></returns>
        public Task<Issue> RemoveAssignees(string owner, string name, int number, AssigneesUpdate assignees)
        {
            Ensure.ArgumentNotNullOrEmptyString(OldGitHubToBeRemoved.Owner, owner);
            Ensure.ArgumentNotNullOrEmptyString(OldGitHubToBeRemoved.Name, name);
            Ensure.ArgumentNotNull(OldGitHubToBeRemoved.Assignees, assignees);

            return ApiConnection.Delete<Issue>(ApiUrls.IssueAssignees(owner, name, number), assignees);
        }

        /// <summary>
        /// Checks to see if a user is an assignee for a repository.
        /// </summary>
        /// <param name="repositoryId">The Id of the repository</param>
        /// <param name="assignee">Username of the prospective assignee</param>
        public async Task<bool> CheckAssignee(long repositoryId, string assignee)
        {
            Ensure.ArgumentNotNullOrEmptyString(OldGitHubToBeRemoved.Assignee, assignee);

            try
            {
                var response = await Connection.Get<object>(ApiUrls.CheckAssignee(repositoryId, assignee), null, null).ConfigureAwait(false);
                return response.HttpResponse.IsTrue();
            }
            catch (NotFoundException)
            {
                return false;
            }
        }
    }
}
