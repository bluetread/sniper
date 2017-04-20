using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Serialization;
using System.Security;
using static Sniper.WarningsErrors.MessageSuppression;

namespace Sniper
{

    [Serializable]

    [SuppressMessage(Categories.Design, MessageAttributes.ImplementStandardExceptionConstructors, Justification = Justifications.SpecificToTargetProcess)]
    public class RepositoryFormatException : Exception
    {
        private readonly string _message;

        public RepositoryFormatException(IEnumerable<string> invalidRepositories)
        {
            var parameterList = string.Join(", ", invalidRepositories);
            _message = string.Format(
                CultureInfo.InvariantCulture,
                "The list of repositories must be formatted as 'owner/name' - these values don't match this rule: {0}", //TODO:const
                parameterList);
        }

        public override string Message => _message;

        /// <summary>
        /// Constructs an instance of LoginAttemptsExceededException
        /// </summary>
        /// <param name="info">
        /// The <see cref="SerializationInfo"/> that holds the
        /// serialized object data about the exception being thrown.
        /// </param>
        /// <param name="context">
        /// The <see cref="StreamingContext"/> that contains
        /// contextual information about the source or destination.
        /// </param>
        protected RepositoryFormatException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            _message = info.GetString("Message"); //TODO:const
        }

        [SecurityCritical]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("Message", Message); //TODO:const
        }

    }
}
