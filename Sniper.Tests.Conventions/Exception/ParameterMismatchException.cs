using System.Reflection;
using System.Runtime.Serialization;

namespace Sniper.Tests.Conventions.Exception
{
    public class ParameterMismatchException : System.Exception
    {
        public ParameterMismatchException(MethodInfo method, int position, ParameterInfo expected, ParameterInfo actual)
            : base(CreateMessage(method, position, expected, actual))
        { }

        public ParameterMismatchException(MethodInfo method, int position, ParameterInfo expected, ParameterInfo actual, System.Exception innerException)
            : base(CreateMessage(method, position, expected, actual), innerException)
        { }

        protected ParameterMismatchException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        { }

        private static string CreateParameterSignature(ParameterInfo parameter)
        {
            return string.Format("{0} {1}", parameter.ParameterType.Name, parameter.Name);
        }

        private static string CreateMessage(MethodInfo method, int position, ParameterInfo expected, ParameterInfo actual)
        {
            var expectedMethodSignature = CreateParameterSignature(expected);
            var actualMethodSignature = CreateParameterSignature(actual);

            return string.Format("Parameter {0} for method {1}.{2} must be \"{3}\" but is \"{4}\"", position, method.DeclaringType.Name, method.Name, expectedMethodSignature, actualMethodSignature);
        }
    }
}