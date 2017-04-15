using System;
using System.Threading.Tasks;
using NSubstitute;
using Xunit;

namespace Sniper.Tests.Clients
{
    public class ReactionsClientTests
    {
        public class TheCtor
        {
            [Fact]
            public void EnsuresNonNullArguments()
            {
                Assert.Throws<ArgumentNullException>(() => new ReactionsClient(null));
            }
        }

        public class TheDeleteMethod
        {
            [Fact]
            public async Task DeletesCorrectUrl()
            {
                var connection = Substitute.For<IApiConnection>();
                var client = new ReactionsClient(connection);

                await client.Delete(42);

                connection.Received().Delete(Arg.Is<Uri>(u => u.ToString() == "reactions/42"), Arg.Any<object>(), "application/vnd.github.squirrel-girl-preview");
            }
        }
    }
}
