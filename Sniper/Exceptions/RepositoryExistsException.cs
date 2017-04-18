using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Security;


namespace Sniper
{
    /// <summary>
    /// Exception thrown when creating a repository, but it already exists on the server.
    /// </summary>

    [Serializable]

    [SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors",
        Justification = "These exceptions are specific to the GitHub API and not general purpose exceptions")]
    public class RepositoryExistsException : ApiValidationException
    {
        private readonly string _message = null;

        /// <summary>
        /// The URL to the existing repository's web page on github.com (or enterprise instance).
        /// </summary>
        public Uri ExistingRepositoryWebUrl { get; set; }

        /// <summary>
        /// A useful default error message.
        /// </summary>
        public override string Message => _message;
        [SecurityCritical]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("Message", Message);
            info.AddValue("ExistingRepositoryWebUrl", ExistingRepositoryWebUrl);
        }
    }
}
