#if false
using System;
using System.Threading.Tasks;
using Sniper.Http;
using Sniper.Request;
using Sniper.Response;


namespace Sniper
{
    /// <summary>
    /// A client for GitHub's Users API.
    /// </summary>
    /// <remarks>
    /// See the <a href="http://developer.github.com/v3/users/">Users API documentation</a> for more information.
    /// </remarks>
    public class UsersClient : ApiClient, IUsersClient
    {
        private static readonly Uri _userEndpoint = new Uri("user", UriKind.Relative);

        /// <summary>
        /// Instantiates a new GitHub Users API client.
        /// </summary>
        /// <param name="apiConnection">An API connection</param>
        public UsersClient(IApiConnection apiConnection) : base(apiConnection)
        {
            Email = new UserEmailsClient(apiConnection);
            Administration = new UserAdministrationClient(apiConnection);
        }

        /// <summary>
        /// A client for GitHub's User Emails API
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/users/emails/">Emails API documentation</a> for more information.
        ///</remarks>
        public IUserEmailsClient Email { get; }

      

        /// <summary>
        /// Returns the user specified by the login.
        /// </summary>
        /// <param name="login">The login name for the user</param>
        public Task<User> Get(string login)
        {
            Ensure.ArgumentNotNullOrEmptyString(nameof(login), login);

            return ApiConnection.Get<User>(ApiUrls.User(login));
        }

        /// <summary>
        /// Returns a <see cref="User"/> for the current authenticated user.
        /// </summary>
        /// <exception cref="AuthorizationException">Thrown if the client is not authenticated.</exception>
        /// <returns>A <see cref="User"/></returns>
        public Task<User> Current()
        {
            return ApiConnection.Get<User>(_userEndpoint);
        }

        /// <summary>
        /// Update the specified <see cref="UserUpdate"/>.
        /// </summary>
        /// <param name="user">The login for the user</param>
        /// <exception cref="AuthorizationException">Thrown if the client is not authenticated.</exception>
        /// <returns>A <see cref="User"/></returns>
        public Task<User> Update(UserUpdate user)
        {
            Ensure.ArgumentNotNull(nameof(user), user);
            
            return ApiConnection.Patch<User>(_userEndpoint, user);
        }

        /// <summary>
        /// A client for GitHub's User Administration API 
        /// </summary>
        /// <remarks>
        /// See the <a href="https://developer.github.com/v3/users/administration/">User Administration API documentation</a> for more information.
        ///</remarks>
        public IUserAdministrationClient Administration { get; }
    }
}
#endif