using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using System;
using Xunit;

namespace Sniper.Tests.CRUD.Update.Common.Times
{
    public class UpdateTimeTests
    {

        [Fact]
        public void UpdateTimeWithDescriptionFieldsSucceeds()
        {
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Times)
            };

            var description = $"Sample Time Description - {DateTime.Now}";
            //Create a time entry
            var time = new Time { Description = description };
            var data = client.CreateData<Time>(time);
            Assert.NotNull(data);
            Assert.False(data.HttpResponse.IsError);

            //get the ID
            var id = data.Data.Id;
            Assert.Equal(data.Data.Description, description);

            // Update the time entry
            var newDescription = $"Sample Modified Time Description - {DateTime.Now}";

            var timeModified = new Time { Id = id, Description = newDescription };
            var newData = client.UpdateData<Time>(timeModified);
            Assert.NotNull(newData);
            Assert.False(newData.HttpResponse.IsError);
            Assert.NotEqual(newData.Data.Description, description);
            Assert.False(newData.HttpResponse.IsError);

            // Verify description changed
            Assert.Equal(newData.Data.Description, newDescription);

            // Verify ID did NOT change
            Assert.Equal(data.Data.Id, newData.Data.Id);
        }
    }
}
