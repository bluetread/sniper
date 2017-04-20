using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Sniper.Tests.Conventions.Exception
{
    public class InterfaceHasAdditionalMethodsException : System.Exception
    {
        public InterfaceHasAdditionalMethodsException(Type type, IEnumerable<string> methodsMissingOnReactiveClient)
            : base(CreateMessage(type, methodsMissingOnReactiveClient))
        { }

        public InterfaceHasAdditionalMethodsException(Type type, IEnumerable<string> methodsMissingOnReactiveClient, System.Exception innerException)
            : base(CreateMessage(type, methodsMissingOnReactiveClient), innerException)
        { }

        protected InterfaceHasAdditionalMethodsException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        { }

        private static string CreateMessage(Type type, IEnumerable<string> methods)
        {
            var methodsFormatted = string.Join("\r\n", methods.Select(m => string.Format(" - {0}", m)));
            return "Methods found on type {0} which should be removed:\r\n{1}"
                      .FormatWithNewLine(
                          type.Name,
                          methodsFormatted);
        }
    }
}