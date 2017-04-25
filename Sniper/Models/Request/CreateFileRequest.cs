#if false
using System.Diagnostics;
using System.Globalization;
using Sniper.Common;
using Sniper.Http;

namespace Sniper.Request
{
    /// <summary>
    /// Base class with common properties for all the Repository Content Request APIs.  //TODO: Replace with TargetProcess if this is usable
    /// </summary>
    public abstract class ContentRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentRequest"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        protected ContentRequest(string message)
        {
            Ensure.ArgumentNotNullOrEmptyString(nameof(message), message);

            Message = message;
        }

     

        /// <summary>
        /// The commit message. This is required.
        /// </summary>
        public string Message { get; }

   

        /// <summary>
        /// Specifies the author to use for the commit. This is optional.
        /// </summary>
        public Committer Author { get; set; }
    }

    /// <summary>
    /// Represents the request to delete a file in a repository.
    /// </summary>
    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + ",nq}")]
    public class DeleteFileRequest : ContentRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFileRequest"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="sha">The sha.</param>
        public DeleteFileRequest(string message, string sha) : base(message)
        {
            Ensure.ArgumentNotNullOrEmptyString(nameof(sha), sha);
            
            Sha = sha;
        }

    
        public string Sha { get; }

        internal string DebuggerDisplay => string.Format(CultureInfo.InvariantCulture, "SHA: {0} Message: {1}", Sha, Message);
    }

    /// <summary>
    /// Represents the parameters to create a file in a repository.
    /// </summary>
    /// <remarks>https://developer.github.com/v3/repos/contents/#create-a-file</remarks>  //TODO: Replace with TargetProcess if this is usable
    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + ",nq}")]
    public class CreateFileRequest : ContentRequest
    {
        /// <summary>
        /// Creates an instance of a <see cref="CreateFileRequest" />.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="content">The content.</param>
        public CreateFileRequest(string message, string content) : this(message, content, true)
        { }

    

        /// <summary>
        /// Creates an instance of a <see cref="CreateFileRequest" />.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="content">The content.</param>
        /// <param name="convertContentToBase64">True to convert content to base64.</param>
        public CreateFileRequest(string message, string content, bool convertContentToBase64) : base(message)
        {
            Ensure.ArgumentNotNull(nameof(content), content);

            if (convertContentToBase64)
            {
                content = content.ToBase64String();
            }
            Content = content;
        }

        /// <summary>
        /// The contents of the file to create, Base64 encoded. This is required.
        /// </summary>
        public string Content { get; }

        internal virtual string DebuggerDisplay => string.Format(CultureInfo.InvariantCulture, "Message: {0} Content: {1}", Message, Content);
    }

    /// <summary>
    /// Represents the parameters to update a file in a repository.
    /// </summary>
    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + ",nq}")]
    public class UpdateFileRequest : CreateFileRequest
    {
        /// <summary>
        /// Creates an instance of a <see cref="UpdateFileRequest" />.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="content">The content.</param>
        /// <param name="sha">The sha.</param>
        public UpdateFileRequest(string message, string content, string sha)
            : this(message, content, sha, true)
        { }

       
        /// <summary>
        /// Creates an instance of a <see cref="UpdateFileRequest" />.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="content">The content.</param>
        /// <param name="sha">The sha.</param>
        /// <param name="convertContentToBase64">True to convert content to base64.</param>
        public UpdateFileRequest(string message, string content, string sha, bool convertContentToBase64)
            : base(message, content, convertContentToBase64)
        {
            Ensure.ArgumentNotNullOrEmptyString(nameof(sha), sha);

            Sha = sha;
        }


        /// <summary>
        /// The blob SHA of the file being replaced.
        /// </summary>
        public string Sha { get; }

        internal override string DebuggerDisplay => string.Format(CultureInfo.InvariantCulture, "SHA: {0} Message: {1}", Sha, Message);
    }
}
#endif