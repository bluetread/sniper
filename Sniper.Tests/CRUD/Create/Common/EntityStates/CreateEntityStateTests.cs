using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.EntityStates
{
    public class CreateEntityStateTests
    {
        [Fact]
        public void CreateEntityStateThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.EntityStates);

            var entityState = new EntityState();
        }
    }
}
