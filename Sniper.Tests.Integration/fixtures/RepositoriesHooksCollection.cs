using Xunit;

namespace Sniper.Tests.Integration.fixtures
{
    [CollectionDefinition(Name)]
    public class RepositoriesHooksCollection : ICollectionFixture<RepositoriesHooksFixture>
    {
        public const string Name = "Repositories Hooks Collection";
    }
}
