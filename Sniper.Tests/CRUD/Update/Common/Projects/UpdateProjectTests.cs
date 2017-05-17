using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using System;
using Xunit;

namespace Sniper.Tests.CRUD.Update.Common.Projects
{
    public class UpdateProjectTests
    {


        [Fact]
        public void UpdateProjectWithMinimumFieldsSucceeds()
        {
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Projects)
            };

            var originalName = $"Sample Project From Code - {DateTime.Now}";
            var project = new Project { Name = originalName };
            var data = client.CreateData<Project>(project);
            Assert.NotNull(data);
            Assert.False(data.HttpResponse.IsError);

            var newName = $"Sample Modified Project Name From Code - {DateTime.Now}";

            var projectModified = new Project { Id = data.Data.Id, Name = newName };

            var newData = client.UpdateData<Project>(projectModified);

            Assert.NotNull(newData);
            Assert.False(newData.HttpResponse.IsError);

            Assert.False(newData.HttpResponse.IsError);

            // Verify name changed
            Assert.NotEqual(newData.Data.Name, originalName);
            Assert.Equal(newData.Data.Name, newName);

            // Verify ID did NOT change
            Assert.Equal(data.Data.Id, newData.Data.Id);
        }
    }
}
