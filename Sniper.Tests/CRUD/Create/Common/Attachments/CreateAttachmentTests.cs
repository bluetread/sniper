using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Attachments
{
    public class CreateAttachmentTests
    {
        [Fact]
        public void AttachmentThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Attachments);

            var attachment = new Attachment();
        }
    }
}
