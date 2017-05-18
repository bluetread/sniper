using Sniper.Common;
using Sniper.TargetProcess.Routes;
using System;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Bugs
{
    public class CreateBugTests
    {
        [Fact]
        public void CreateBugThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Bugs);

            var bug = new Bug();
            var data = client.CreateData<Bug>(bug);

            Assert.NotNull(data);
            Assert.True(data.HttpResponse.IsError);
        }


        [Fact]
        public void CreateBugWithMinimumDataSucceeds()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Bugs);

            var bug = new Bug
            {
                Name = $"Sample Bug From Code - {DateTime.Now}",
                Project = new Project { Id = 194 },
            };
            var data = client.CreateData<Bug>(bug);

            Assert.NotNull(data);
            Assert.False(data.HttpResponse.IsError);
        }
    }
}
