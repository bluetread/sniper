using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Sniper.Tests.CRUD.Create;
using Xunit;

namespace Sniper.Tests.CRUD.Undelete
{
    public class UndeleteTests
    {
        [Fact]
        public void UnDeleteProjectWithValidIdSucceeds()
        {
            var client = new TargetProcessClient { ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Projects) };
            // First, Create a project 

            var data = CreateCommonMethods.GetNewProject(client);
            var createdId = data.Data.Id;

            Assert.NotEqual(0, createdId);
            Assert.NotNull(createdId);

            // Then, Delete it
            var result = client.DeleteData<Project>((int)createdId);
            Assert.NotNull(result);
            Assert.NotNull(result.Data.Id);

            // Then undelete the project
            var undeleteClient = new TargetProcessClient { ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Undelete) };
            var undeleteProjectData = undeleteClient.UndeleteProjectData((int)createdId);

            Assert.NotNull(undeleteProjectData);
            Assert.False(undeleteProjectData.HttpResponse.IsError);

        }

        [Fact]
        public void UnDeleteUserWithValidIdSucceeds()
        {
            var client = new TargetProcessClient { ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Users) };
            // First, Create a user

            var user = new User { FirstName = "Test", LastName = "User", Login = "TestUser", Email = "test@test.com", Password = "test" };
            var data = client.CreateUser(user);
            var createdId = data.Data.Id;

            Assert.NotEqual(0, createdId);
            Assert.NotNull(createdId);

            // Then, Delete it
            var result = client.DeleteData<User>((int)createdId);
            Assert.NotNull(result);
            Assert.NotNull(result.Data.Id);

            // Then undelete the user
            var undeleteClient = new TargetProcessClient { ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Undelete) };
            var undeleteUserData = undeleteClient.UndeleteUserData((int)createdId);

            Assert.NotNull(undeleteUserData);
            Assert.False(undeleteUserData.HttpResponse.IsError);

        }
    }
}
