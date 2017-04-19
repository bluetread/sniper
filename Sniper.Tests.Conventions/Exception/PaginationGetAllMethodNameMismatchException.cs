using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Sniper.Tests.Conventions.Exception
{
    public class PaginationGetAllMethodNameMismatchException : System.Exception
    {
        public PaginationGetAllMethodNameMismatchException(Type type, IEnumerable<MethodInfo> methods)
            : base(CreateMessage(type, methods))
        { }

        private static string CreateMessage(Type type, IEnumerable<MethodInfo> methods)
        {
            var methodsFormatted = string.Join("\r\n", methods.Select(m => string.Format(" - {0}", m)));
            return "Methods found on type {0} should follow the 'GetAll*' naming convention:\r\n{1}"
                      .FormatWithNewLine(
                          type.Name,
                          methodsFormatted);
        }
    }
}
