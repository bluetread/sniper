using System.Diagnostics;
using System.Globalization;

namespace Sniper.Request
{
    /// <summary>
    /// Describes a new commit comment to create via the <see cref="IRepositoryCommentsClient.Create(string,string,string,NewCommitComment)"/> method.
    /// </summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class NewCommitComment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewCommitComment"/> class.
        /// </summary>
        /// <param name="body">The body of the comment.</param>
        public NewCommitComment(string body)
        {
            Ensure.ArgumentNotNull(body, "body");

            Body = body;
        }

        /// <summary>
        /// The contents of the comment (required)
        /// </summary>
        public string Body { get; }

        /// <summary>
        /// Relative path of the file to comment on
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Line index in the diff to comment on
        /// </summary>
        public int? Position { get; set; }

        internal string DebuggerDisplay
        {
            get
            {
                return string.Format(CultureInfo.InvariantCulture, "Path: {0}, Body: {1}", Path, Body);
            }
        }
    }
}
