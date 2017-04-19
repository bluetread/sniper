#if false
using System;

namespace Sniper.Response
{
    /// <summary>
    /// Base class for a GitHub account, most often either a <see cref="User"/> or <see cref="Organization"/>.  //TODO: Replace with TargetProcess if this is usable
    /// </summary>
    public abstract class Account  //TODO: Replace with TargetProcess if this is usable
    {
        protected Account() { }

        protected Account(string avatarUrl, string bio, string blog, string company, DateTimeOffset createdAt, int diskUsage, string email, string htmlUrl, int id, string location, string login, string name, AccountType type, string url)
        {
            AvatarUrl = avatarUrl;
            Bio = bio;
            Blog = blog;
            Company = company;
            CreatedAt = createdAt;
            DiskUsage = diskUsage;
            Email = email;
            HtmlUrl = htmlUrl;
            Id = id;
            Location = location;
            Login = login;
            Name = name;
            Type = type;
            Url = url;
        }

        /// <summary>
        /// URL of the account's avatar.
        /// </summary>
        public string AvatarUrl { get; protected set; }

        /// <summary>
        /// The account's bio.
        /// </summary>
        public string Bio { get; protected set; }

        /// <summary>
        /// URL of the account's blog.
        /// </summary>
        public string Blog { get; protected set; }

        /// <summary>
        /// Number of collaborators the account has.
        /// </summary>
        public int? Collaborators { get; protected set; }

        /// <summary>
        /// Company the account works for.
        /// </summary>
        public string Company { get; protected set; }

        /// <summary>
        /// Date the account was created.
        /// </summary>
        public DateTimeOffset CreatedAt { get; protected set; }

        /// <summary>
        /// Amount of disk space the account is using.
        /// </summary>
        public int? DiskUsage { get; protected set; }

        /// <summary>
        /// The account's email.
        /// </summary>
        public string Email { get; protected set; }

        /// <summary>
        /// The HTML URL for the account on github.com (or GitHub Enterprise).  //TODO: Replace with TargetProcess if this is usable
        /// </summary>
        public string HtmlUrl { get; protected set; }

        /// <summary>
        /// The account's system-wide unique Id.
        /// </summary>
        public int Id { get; protected set; }

        /// <summary>
        /// The account's geographic location.
        /// </summary>
        public string Location { get; protected set; }

        /// <summary>
        /// The account's login.
        /// </summary>
        public string Login { get; protected set; }

        /// <summary>
        /// The account's full name.
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// The type of account associated with this entity
        /// </summary>
        SuppressMessage(Categories.Naming, "CA1721:PropertyNamesShouldNotMatchGetMethods")]
        public AccountType? Type { get; protected set; }


        /// <summary>
        /// Number of private repos owned by the account.
        /// </summary>
        public int OwnedPrivateRepos { get; protected set; }

    

        /// <summary>
        /// The account's API URL.
        /// </summary>
        public string Url { get; protected set; }
    }
}
#endif