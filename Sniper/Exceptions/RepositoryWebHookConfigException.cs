using System;
using System.Collections.Generic;
using static Sniper.WarningsErrors.MessageSuppression;
using System.Diagnostics.CodeAnalysis;

using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Security;

namespace Sniper
{

    [Serializable]

    [SuppressMessage(Categories.Design, MessageAttributes.ImplementStandardExceptionConstructors, Justification = Justifications.SpecificToTargetProcess)]
    public class RepositoryWebHookConfigException : Exception
    {
        private readonly string _message;

        public RepositoryWebHookConfigException(IEnumerable<string> invalidConfig)
        {
            var parameterList = string.Join(", ", invalidConfig.Select(ic => ic.FromRubyCase()));
            _message = string.Format(CultureInfo.InvariantCulture,
                "Duplicate webhook config values found - these values: {0} should not be passed in as part of the config values. Use the properties on the NewRepositoryWebHook class instead.", //TODO:const
                parameterList);
        }

        public override string Message => _message;

        /// <summary>
        /// Constructs an instance of RepositoryWebHookConfigException
        /// </summary>
        /// <param name="info">
        /// The <see cref="SerializationInfo"/> that holds the
        /// serialized object data about the exception being thrown.
        /// </param>
        /// <param name="context">
        /// The <see cref="StreamingContext"/> that contains
        /// contextual information about the source or destination.
        /// </param>
        protected RepositoryWebHookConfigException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            _message = info.GetString("Message");//TODO:const
        }

        [SecurityCritical]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("Message", Message);//TODO:const
        }

    }
}
