using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using System;
using Xunit;

namespace Sniper.Tests.CRUD.Update.Common.Epics
{
    public class UpdateEpicTests
    {
        [Fact]
        public void UpdateEpicWithMinimumDataSucceeds()
        {
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Epics)
            };

            var originalName = $"Sample Epic From Code - {DateTime.Now}";
            var epic = new Epic
            {
                Name = originalName,
                Project = new Project { Id = 194 }
            };

            var data = client.CreateData<Epic>(epic);

            Assert.NotNull(data);
            Assert.False(data.HttpResponse.IsError);

            var newName = $"Sample Modified Epic From Code - {DateTime.Now}";
            var newEpic = new Epic { Id = data.Data.Id, Project = data.Data.Project, Name = newName };
            var newData = client.UpdateData<Epic>(newEpic);

            // Verify name changed
            Assert.NotEqual(newData.Data.Name, originalName);
            Assert.Equal(newData.Data.Name, newName);

            // Verify ID did NOT change
            Assert.Equal(data.Data.Id, newData.Data.Id);


        }
    }
}
