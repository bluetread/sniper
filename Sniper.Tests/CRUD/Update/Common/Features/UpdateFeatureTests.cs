using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using System;
using Xunit;

namespace Sniper.Tests.CRUD.Update.Common.Features
{
    public class UpdateFeatureTests
    {
        [Fact]
        public void UpdateFeatureWithNameAndProjectIdSucceeds()
        {
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Features)
            };

            var name = $"Sample Feature From Code - {DateTime.Now}";
            var feature = new Feature
            {
                Name = name,
                Project = new Project { Id = 194 }
            };

            var data = client.CreateData<Feature>(feature);

            Assert.NotNull(data);
            Assert.False(data.HttpResponse.IsError);

            var newName = $"Sample Modified Feature From Code - {DateTime.Now}";

            var newFeature = new Feature { Id = data.Data.Id, Name = newName, Project = data.Data.Project };
            var newData = client.UpdateData<Feature>(newFeature);

            // Verify name changed
            Assert.NotEqual(newData.Data.Name, name);
            Assert.Equal(newData.Data.Name, newName);

            // Verify ID did NOT change
            Assert.Equal(data.Data.Id, newData.Data.Id);
        }
    }
}
