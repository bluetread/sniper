using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Read.Common.Assignables
{
    public class ReadAssignableTests
    {
        [Fact]
        public void CreateAssignableThrowsError()
        {
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Assignables)
            };
            var assignable = new Assignable
            {
                //EntityState = new EntityState { Name = "Some Entity state"}
            };
            var data = client.CreateData<Assignable>(assignable);
        }
    }
}
