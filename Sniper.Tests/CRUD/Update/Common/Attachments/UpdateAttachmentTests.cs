using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Update.Common.Attachments
{
    public class UpdateAttachmentTests
    { 
        [Fact] 
        public void AttachmentThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Attachments) 
            }; 
            var attachment = new Attachment 
            { 
            }; 
        } 
    } 
} 
