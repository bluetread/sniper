using System.Threading.Tasks;
using Sniper.Http;

namespace Sniper
{
    /// <summary>
    /// A client for GitHub's Issue Assignees API.
    /// </summary>
    public class AssigneesClient : ApiClient //, IAssigneesClient
    {
        /// <summary>
        /// Instantiates a new GitHub Issue Assignees API client.
        /// </summary>
        /// <param name="apiConnection">An API connection</param>
        public AssigneesClient(IApiConnection apiConnection) : base(apiConnection) {}


        /// <summary>
        /// Checks to see if a user is an assignee for a repository.
        /// </summary>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="assignee">Username of the prospective assignee</param>
        public async Task<bool> CheckAssignee(string owner, string name, string assignee)
        {
            Ensure.ArgumentNotNullOrEmptyString(nameof(owner), owner);
            Ensure.ArgumentNotNullOrEmptyString(nameof(name), name);
            Ensure.ArgumentNotNullOrEmptyString(nameof(assignee), assignee);

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

       
    }
}
