using Sniper.Application.Messages;
using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.TestRunItemHierarchyLinks
{
    public class CreateTestRunItemHierarchyLinkTests
    {
        [Fact]
        public void CreateTestRunItemHierarchyLinkThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.TestRunItemHierarchyLinks);
            var testRunItemHierarchyLink = new TestRunItemHierarchyLink();
            var data = client.CreateData<General>(testRunItemHierarchyLink);

            Assert.NotNull(data);
            Assert.True(data.HttpResponse.IsError);
            Assert.Equal(data.HttpResponse.Exception.GetType(), typeof(SniperExceptions.RequiredPropertyException));

            var exception = (SniperExceptions.RequiredPropertyException)data.HttpResponse.Exception;
            Assert.Equal(exception.RequiredDataResponse.Message, CrudMessages.AllProhibited);
        }
    }
}
