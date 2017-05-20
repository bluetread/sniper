using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.RelationTypes
{
    public class CreateRelationTypeTests
    {
        [Fact]
        public void CreateRelationTypeThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.RelationTypes);

            var relationType = new RelationType();
        }
    }
}
