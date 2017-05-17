using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using System;
using System.Net;
using Xunit;

namespace Sniper.Tests.CRUD.Delete.Common.Features
{
    public class DeleteFeatureTests
    {
        [Fact]
        public void DeleteFeatureWithInvalidIdThrowsError()
        {
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Features)
            };

            var data = client.DeleteData<Feature>(2);
            Assert.NotNull(data);
            Assert.True(data.HttpResponse.IsError);
            Assert.Null(data.Data);
            Assert.Equal(data.HttpResponse.StatusCode, HttpStatusCode.NotFound);
        }

        [Fact]
        public void CreateFeatureAndThenDeleteItSucceeds()
        {
            //Create a feature
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Features)
            };

            var feature = new Feature
            {
                Name = $"Sample Feature From Code - {DateTime.Now}",
                Project = new Project { Id = 194 }
            };

            var data = client.CreateData<Feature>(feature);
            Assert.NotNull(data);
            Assert.False(data.HttpResponse.IsError);
            Assert.NotNull(data.Data.Project);
            Assert.NotNull(data.Data.Project.Id);

            var createdId = data.Data.Id;
            Assert.NotEqual(0, createdId);
            Assert.NotNull(createdId);

            var result = client.DeleteData<Feature>((int)createdId);
            Assert.NotNull(result);
            Assert.NotNull(result.Data.Id);
            Assert.Equal(createdId, result.Data.Id);
            Assert.Null(result.Data.Project);
        }
    }
}
