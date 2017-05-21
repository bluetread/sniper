using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Delete.Common.Attachments
{
    public class DeleteAttachmentTests
    {
        [Fact]
        public void AttachmentThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Attachments);

            var attachment = new Attachment();
        }
    }
}
