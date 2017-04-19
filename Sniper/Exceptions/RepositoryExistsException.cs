using System;
using static Sniper.WarningsErrors.MessageSuppression;
using System.Diagnostics.CodeAnalysis;

using System.Runtime.Serialization;
using System.Security;


namespace Sniper
{
    /// <summary>
    /// Exception thrown when creating a repository, but it already exists on the server.
    /// </summary>

    [Serializable]

    [SuppressMessage(Categories.Design, MessageAttributes.ImplementStandardExceptionConstructors, Justification = Justifications.SpecificToTargetProcess)]
    public class RepositoryExistsException : ApiValidationException
    {
        private readonly string _message = null;

        /// <summary>
        /// The URL to the existing repository's web page on github.com (or enterprise instance).  //TODO: Replace with TargetProcess if this is usable
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
            info.AddValue("ExistingRepositoryWebUrl", ExistingRepositoryWebUrl); //TODO:const
        }
    }
}
