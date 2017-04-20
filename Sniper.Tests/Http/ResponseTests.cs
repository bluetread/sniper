using Xunit;

namespace Sniper.Tests.Http
{
    public class ResponseTests
    {
        public class TheConstructor
        {
            [Fact]
            public void InitializesAllRequiredProperties()
            {
                var r = new Response();

                Assert.NotNull(r.Headers);
            }
        }
    }
}
