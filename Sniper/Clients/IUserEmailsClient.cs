﻿#if false
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using Sniper.Request;
using Sniper.Response;

namespace Sniper
{
    /// <summary>
    /// A client for GitHub's User Emails API.  //TODO: Replace with TargetProcess if this is usable
    /// </summary>
    /// <remarks>
    /// See the <a href="http://developer.github.com/v3/users/emails/">User Emails API documentation</a> for more information.  //TODO: Replace with TargetProcess if this is usable
    /// </remarks>
    public interface IUserEmailsClient
    {
        /// <summary>
        /// Gets all email addresses for the authenticated user.
        /// </summary>
        /// <remarks>
        /// http://developer.github.com/v3/users/emails/#list-email-addresses-for-a-user  //TODO: Replace with TargetProcess if this is usable
        /// </remarks>
        /// <returns>The <see cref="EmailAddress"/>es for the authenticated user.</returns>
        [SuppressMessage(Categories.Design, "CA1024:UsePropertiesWhereAppropriate")]
        Task<IReadOnlyList<EmailAddress>> GetAll();

        /// <summary>
        /// Gets all email addresses for the authenticated user.
        /// </summary>
        /// <remarks>
        /// http://developer.github.com/v3/users/emails/#list-email-addresses-for-a-user  //TODO: Replace with TargetProcess if this is usable
        /// </remarks>
        /// <param name="options">Options for changing the API response</param>
        /// <returns>The <see cref="EmailAddress"/>es for the authenticated user.</returns>
        [SuppressMessage(Categories.Design, "CA1024:UsePropertiesWhereAppropriate")]
        Task<IReadOnlyList<EmailAddress>> GetAll(ApiOptions options);

        /// <summary>
        /// Adds email addresses for the authenticated user.
        /// </summary>
        /// <remarks>
        /// http://developer.github.com/v3/users/emails/#add-email-addresses  //TODO: Replace with TargetProcess if this is usable
        /// </remarks>
        /// <param name="emailAddresses">The email addresses to add.</param>
        /// <returns>Returns the added <see cref="EmailAddress"/>es.</returns>
        Task<IReadOnlyList<EmailAddress>> Add(params string[] emailAddresses);

        /// <summary>
        /// Deletes email addresses for the authenticated user.
        /// </summary>
        /// <remarks>
        /// http://developer.github.com/v3/users/emails/#delete-email-addresses  //TODO: Replace with TargetProcess if this is usable
        /// </remarks>
        /// <param name="emailAddresses">The email addresses to delete.</param>
        /// <returns>Returns the added <see cref="EmailAddress"/>es.</returns>
        Task Delete(params string[] emailAddresses);
    }
}
#endif