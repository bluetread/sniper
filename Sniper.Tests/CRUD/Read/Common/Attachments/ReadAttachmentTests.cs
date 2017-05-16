using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Read.Common.Attachments
{
    public class ReadAttachmentTests
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
