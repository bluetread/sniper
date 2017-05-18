using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Relations
{
    public class CreateRelationTests
    {
        [Fact]
        public void RelationThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Relations);

            var relation = new Relation();
        }
    }
}
