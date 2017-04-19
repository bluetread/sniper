using System;
using Xunit;

namespace Sniper.Tests.Models
{
    public class NewReferenceTests
    {
        public class TheCtor
        {
            [Fact]
            public void EnforcesRefsPrefix()
            {
                var create = new NewReference("heads/develop", "sha");

                Assert.Equal(create.Ref, "refs/heads/develop");
            }

            [Fact]
            public void ThrowsExceptionIfRefHasLessThanTwoSlashes()
            {
                Assert.Throws<FormatException>(() => new NewReference("refs/develop", "sha"));
            }
        }
    }
}