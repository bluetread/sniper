using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Attachments 
{ 
    public class AttachmentTests 
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
