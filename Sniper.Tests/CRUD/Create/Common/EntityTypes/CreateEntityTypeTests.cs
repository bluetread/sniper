using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.EntityTypes
{
    public class CreateEntityTypeTests
    {
        [Fact]
        public void EntityTypeThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.EntityTypes);

            var entityType = new EntityType();
        }
    }
}
