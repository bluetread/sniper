using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sniper.Configuration;

namespace Sniper.Tests.Fixtures
{
    public class AuthenticationFixture : IDisposable
    {
        private readonly ConfigurationData _configData = ConfigurationData.Instance;
        public AuthenticationFixture()
        {
        }

        public void Dispose()
        {
        }
    }
}
