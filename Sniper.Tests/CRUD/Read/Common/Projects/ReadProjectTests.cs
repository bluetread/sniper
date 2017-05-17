using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using System;
using Xunit;

namespace Sniper.Tests.CRUD.Read.Common.Projects
{
    public class ReadProjectTests
    {
        [Fact]
        public void ProjectThrowsError()
        {
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Projects)
            };
            var project = new Project
            {
            };
        }

        [Fact]
        public void CreateProjectWithoutNameThrowsError()
        {
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Projects)
            };

            var project = new Project();
            var data = client.CreateData<Project>(project);
            Assert.NotNull(data);
            Assert.True(data.HttpResponse.IsError);
        }

        [Fact]
        public void CreateProjectWithMinimumFieldsSucceeds()
        {
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Projects)
            };

            var project = new Project
            {
                Name = $"Sample Project From Code - {DateTime.Now}"
            };
            var data = client.CreateData<Project>(project);
            Assert.NotNull(data);
            Assert.False(data.HttpResponse.IsError);
        }
    }
}
