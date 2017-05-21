using Sniper.Application.Messages;
using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.EntityTypes
{
    public class CreateEntityTypeTests
    {
        [Fact]
        public void CreateEntityTypeThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.EntityTypes);

            var entityType = new EntityType();
            var data = client.CreateData<EntityType>(entityType);

            Assert.NotNull(data);
            Assert.True(data.HttpResponse.IsError);
            Assert.Equal(data.HttpResponse.Exception.GetType(), typeof(SniperExceptions.RequiredPropertyException));

            var exception = (SniperExceptions.RequiredPropertyException)data.HttpResponse.Exception;
            Assert.Equal(exception.RequiredDataResponse.Message, CrudMessages.AllProhibited);
        }
    }
}
