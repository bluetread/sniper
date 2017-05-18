using Sniper.Application.Messages;
using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.AssignedEfforts
{
    public class CreateAssignedEffortTests
    {
        [Fact]
        public void CreateAssignedEffortThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.AssignedEfforts);

            var assignedEffort = new AssignedEffort();
            var data = client.CreateData<AssignedEffort>(assignedEffort);

            Assert.NotNull(data);
            Assert.True(data.HttpResponse.IsError);
            Assert.Equal(data.HttpResponse.Exception.GetType(), typeof(SniperExceptions.RequiredPropertyException));

            var exception = (SniperExceptions.RequiredPropertyException)data.HttpResponse.Exception;
            Assert.Equal(exception.RequiredDataResponse.Message, CrudMessages.CreateProhibited);
        }
    }
}
