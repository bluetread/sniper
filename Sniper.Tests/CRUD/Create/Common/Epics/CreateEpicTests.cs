using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using System;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Epics
{
    public class CreateEpicTests
    {
        [Fact]
        public void CreateEpicThrowsError()
        {
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Epics)
            };
            var epic = new Epic();
            var data = client.CreateData<Epic>(epic);

            Assert.NotNull(data);
            Assert.True(data.HttpResponse.IsError);
        }

        [Fact]
        public void CreateEpicithoutProjectIdFails()
        {
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Epics)
            };

            var epic = new Epic
            {
                Name = $"Sample Epic From Code - {DateTime.Now}",
            };

            var data = client.CreateData<Epic>(epic);

            Assert.NotNull(data);
            Assert.True(data.HttpResponse.IsError);
        }

        [Fact]
        public void CreateEpicWithMinimumDataSucceeds()
        {
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Epics)
            };

            var epic = new Epic
            {
                Name = $"Sample Epic From Code - {DateTime.Now}",
                Project = new Project { Id = 194 }
            };

            var data = client.CreateData<Epic>(epic);

            Assert.NotNull(data);
            Assert.False(data.HttpResponse.IsError);
        }

        [Fact]
        public void CreateHelperEpicWithMinimumDataSucceeds()
        {
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Epics)
            };

            var epic = new Epic
            {
                Name = $"Sample Epic From Code - {DateTime.Now}",
                Project = new Project { Id = 194 }
            };

            var data = client.CreateEpic(epic);

            Assert.NotNull(data);
            Assert.False(data.HttpResponse.IsError);
        }

        [Fact]
        public void CreateHelperEpicAsyncWithMinimumDataSucceeds()
        {
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Epics)
            };

            var epic = new Epic
            {
                Name = $"Sample Epic From Code - {DateTime.Now}",
                Project = new Project { Id = 194 }
            };

            var data = client.CreateEpicAsync(epic);

            Assert.NotNull(data);
            Assert.False(data.Result.HttpResponse.IsError);
        }
    }
}
