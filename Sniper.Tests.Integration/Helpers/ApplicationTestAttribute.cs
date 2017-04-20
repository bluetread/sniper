using System.Collections.Generic;
using System.Linq;
using Xunit;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Sniper.Tests.Integration.Helpers
{
    public class ApplicationTestDiscoverer : IXunitTestCaseDiscoverer
    {
        private readonly IMessageSink diagnosticMessageSink;

        public ApplicationTestDiscoverer(IMessageSink diagnosticMessageSink)
        {
            this.diagnosticMessageSink = diagnosticMessageSink;
        }


        public IEnumerable<IXunitTestCase> Discover(ITestFrameworkDiscoveryOptions discoveryOptions, ITestMethod testMethod, IAttributeInfo factAttribute)
        {
            if (string.IsNullOrWhiteSpace(Helper.ClientId)
                && string.IsNullOrWhiteSpace(Helper.ClientSecret))
            {
                return Enumerable.Empty<IXunitTestCase>();
            }

            return new[] { new XunitTestCase(diagnosticMessageSink, discoveryOptions.MethodDisplayOrDefault(), testMethod) };
        }
    }

    [XunitTestCaseDiscoverer("Sniper.Tests.Integration.ApplicationTestDiscoverer", "Sniper.Tests.Integration")]
    public class ApplicationTestAttribute : FactAttribute
    {
    }
}
