using System.Collections.Generic;
using System.Threading.Tasks;
using NSubstitute;
using Xunit;

namespace Sniper.Tests.Http
{
    public class ReadOnlyPagedCollectionTests
    {
        public class TheConstructor
        {
            [Fact]
            public void AcceptsAResponseWithANullBody()
            {
                var response = Substitute.For<IApiResponse<List<string>>>();
                response.Body.Returns((List<string>)null);

                var exception = Record.Exception(() =>
                    new ReadOnlyPagedCollection<string>(response, uri => Task.FromResult(response)));

                Assert.Null(exception);
            }
        }
    }
}
