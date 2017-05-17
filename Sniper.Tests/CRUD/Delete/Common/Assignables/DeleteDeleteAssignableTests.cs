using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Delete.Common.Assignables
{
    public class DeleteDeleteAssignableTests
    {
        [Fact]
        public void DeleteAssignableThrowsError()
        {
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Assignables)
            };
            var assignable = new Assignable
            {
                //EntityState = new EntityState { Name = "Some Entity state"}
            };
        }
    }
} 
