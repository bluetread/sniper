using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.RevisionFiles
{
    public class CreateRevisionFileTests
    {
        [Fact]
        public void CreateRevisionFileThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.RevisionFiles);

            var revisionFile = new RevisionFile();
        }
    }
}
