using System.Runtime.Serialization;

namespace Sniper.Tests.Conventions.Exception
{
    public class InterfaceNotFoundException : System.Exception
    {
        public InterfaceNotFoundException() { }

        public InterfaceNotFoundException(string type)
            : base(CreateMessage(type))
        { }

        public InterfaceNotFoundException(string type, System.Exception innerException)
            : base(CreateMessage(type), innerException)
        { }

        protected InterfaceNotFoundException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        { }

        private static string CreateMessage(string type)
        {
            return string.Format("Could not find the interface {0}. Add this to the Sniper.Reactive project", type);
        }
    }
}
