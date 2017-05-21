using Sniper.Application;
using Sniper.Common;
using Sniper.TargetProcess.Routes;
using System.Collections.Generic;
using System.Net;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Assignments
{
    public class CreateAssignmentTests
    {
        [Fact]
        public void CreateAssignmentWithoutRequiredFieldsThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Assignments);

            var assignment = new Assignment();
            var data = client.CreateData<Assignment>(assignment);

            Assert.NotNull(data);
            Assert.True(data.HttpResponse.IsError);

            var exception = (SniperExceptions.RequiredPropertyException)data.HttpResponse.Exception;
            var listOfMissingProperties = exception.RequiredDataResponse.MissingPropertyNames;
            var compareList = new List<string> { JsonProperties.Assignable, JsonProperties.GeneralUser, JsonProperties.Role };
            Assert.Equal(3, listOfMissingProperties.Count);

            foreach (var item in listOfMissingProperties)
            {
                Assert.True(compareList.Contains(item));
            }
        }

        [Fact] //TODO: Check this
        public void CreateAssignmentWithAssignableFailsSinceAbstract()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Assignments);

            var assignment = new Assignment
            {
                Assignable = new Assignable(),
                GeneralUser = new User(),
                Role = new Role()
            };
            var data = client.CreateData<Assignment>(assignment);

            Assert.NotNull(data);
            Assert.True(data.HttpResponse.IsError);
            Assert.Equal(data.HttpResponse.StatusCode, HttpStatusCode.MethodNotAllowed);
        }

        [Fact] //TODO: Check this
        public void CreateAssignmentWithRequiredFieldsSucceeds()
        {
        }
    }
}
