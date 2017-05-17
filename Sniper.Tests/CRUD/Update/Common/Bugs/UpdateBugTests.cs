using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using System;
using Xunit;

namespace Sniper.Tests.CRUD.Update.Common.Bugs
{
    public class UpdateBugTests
    {


        [Fact]
        public void UpdateBugWithMinimumDataSucceeds()
        {
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Bugs)
            };

            var originalName = $"Sample Bug From Code - {DateTime.Now}";

            var bug = new Bug
            {
                Name = originalName,
                Project = new Project { Id = 194 },
            };
            var data = client.CreateData<Bug>(bug);

            Assert.NotNull(data);
            Assert.False(data.HttpResponse.IsError);

            var newName = $"Sample Modified Bug From Code - {DateTime.Now}";
            var newBug = new Bug { Id = data.Data.Id, Project = data.Data.Project, Name = newName };
            var newData = client.UpdateData<Bug>(newBug);

            // Verify name changed
            Assert.NotEqual(newData.Data.Name, originalName);
            Assert.Equal(newData.Data.Name, newName);

            // Verify ID did NOT change
            Assert.Equal(data.Data.Id, newData.Data.Id);
        }
    }
}
