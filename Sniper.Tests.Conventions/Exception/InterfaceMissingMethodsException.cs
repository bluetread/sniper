using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Sniper.Tests.Conventions.Exception
{
    public class InterfaceMissingMethodsException : System.Exception
    {
        public InterfaceMissingMethodsException(Type type, IEnumerable<string> methodsMissingOnReactiveClient)
            : base(CreateMessage(type, methodsMissingOnReactiveClient))
        { }

        public InterfaceMissingMethodsException(Type type, IEnumerable<string> methodsMissingOnReactiveClient, System.Exception innerException)
            : base(CreateMessage(type, methodsMissingOnReactiveClient), innerException)
        { }

        protected InterfaceMissingMethodsException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        { }

        private static string CreateMessage(Type type, IEnumerable<string> methods)
        {
            var methodsFormatted = string.Join("\r\n", methods.Select(m => string.Format(" - {0}", m)));
            return "Methods not found on interface {0} which are required:\r\n{1}"
                       .FormatWithNewLine(type.Name, methodsFormatted);
        }
    }
}