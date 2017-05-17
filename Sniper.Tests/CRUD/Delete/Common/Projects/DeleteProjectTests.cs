using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using System;
using Xunit;

namespace Sniper.Tests.CRUD.Delete.Common.Projects
{
    public class DeleteProjectTests
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
        public void DeleteProjectWithoutNameThrowsError()
        {
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Projects)
            };

            var project = new Project();
        }

        [Fact]
        public void DeleteProjectWithMinimumFieldsSucceeds()
        {
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Projects)
            };

            var project = new Project
            {
                Name = $"Sample Project From Code - {DateTime.Now}"
            };
        }
    }
}
